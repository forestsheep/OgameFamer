﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Management;
using System.Net.Mail;
using GalaxyFarmer.messager;
using log4net;

namespace GalaxyFarmer
{
    public partial class LoginForm : Form
    {
        #region old way
        private StarScript ss;
        #endregion

        #region new way
        private LoginCommander loginCommander;
        private BallListCommander ballListCommander;
        #endregion

        public LoginForm()
        {
            InitializeComponent();

            ProgramStatic.LOGIN_FORM = this;

            #region old way
            this.ss = new StarScript();
            //ss.LoginEvent += this.OnLogin;
            #endregion

            #region new way
            #endregion
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cb_uni.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_uni.SelectedIndex = 1;
            tb_username.Text = "隔江犹唱后庭花";
            tb_pw.Text = "911911f911";
            //tb_username.Text = "boccaro";
            //tb_pw.Text = "911911f911";
            #region test area
            // mail test
            //string to = "forestsheep@163.com";
            //string subject ="你妹啊，收到了么？";
            //string body = "我日啊我日哦";
            //MailSender ms = new MailSender(Admin.MAIL_NAME, Admin.MAIL_SMTP_SERVER, Admin.MAIL_ADDRESS, Admin.MAIL_PW);
            //ms.Mailto(to, subject, body);
            #endregion
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            login();
            //Main m = new Main();
            //m.Show();
            //this.Hide();
        }

        #region new way
        private void login()
        {
            this.b_login.Text = "login...";
            this.b_login.Enabled = false;
            LoginMessager loginMessager = new LoginMessager(this.tb_username.Text, this.tb_pw.Text, cb_uni.SelectedItem.ToString());
            loginCommander = new LoginCommander(loginMessager, this.OnLogin);
            CommandCenter.RUN(loginCommander, this);
        }
        #endregion

        private void OnLogin()
        {
            Object[] list = { this, System.EventArgs.Empty };
            this.l_loginMessage.BeginInvoke(new EventHandler(ResponseLogin), list);
        }

        private void OnBallList()
        {
            Object[] list = { this, System.EventArgs.Empty };
            this.l_loginMessage.BeginInvoke(new EventHandler(ResponseBallList), list);
        }

        public void ResponseLogin(object sender, EventArgs e)
        {
            //if (li.LoginSuccess)
            if (this.loginCommander.Messager.ResIsLoginSuccess)
            {
                StarScript.loginname = this.tb_username.Text;
                StarScript.password = this.tb_pw.Text;
                StarScript.universe = cb_uni.SelectedItem.ToString();
                Profile.LOGIN_NAME = this.loginCommander.Messager.ReqLoginName;
                Profile.PASSWORD = this.loginCommander.Messager.ReqPassword;
                Profile.UNIVERSE = this.loginCommander.Messager.ReqUniverse;
                loginCommander.LoginEvent -= this.OnLogin;
                // 获取所有球的列表
                ballListCommander = new BallListCommander(this.OnBallList);
                CommandCenter.RUN(ballListCommander, this);
            }
            else
            {
                b_login.Text = "Login";
                b_login.Enabled = true;
                l_loginMessage.Text = "登录失败";
            }
        }

        internal void ResponseBallList(object sender, EventArgs e)
        {
            ballListCommander.BallListEvent -= this.OnBallList;
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void tb_pw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }
    }
}
