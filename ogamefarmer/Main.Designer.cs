﻿namespace OgameFarmer
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        } 

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.outputArea = new System.Windows.Forms.TextBox();
            this.btnOverView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.l_ballname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_metal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_metalstroe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_crystal = new System.Windows.Forms.Label();
            this.l_crystalstore = new System.Windows.Forms.Label();
            this.l_hstore = new System.Windows.Forms.Label();
            this.l_h = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.l_energystore = new System.Windows.Forms.Label();
            this.l_energy = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_ball_list = new System.Windows.Forms.ListBox();
            this.l_metal_all = new System.Windows.Forms.Label();
            this.l_crystal_all = new System.Windows.Forms.Label();
            this.l_H_all = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.noti = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.l_hh_all = new System.Windows.Forms.Label();
            this.l_crystalh_all = new System.Windows.Forms.Label();
            this.l_metalh_all = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.l_h_allday = new System.Windows.Forms.Label();
            this.l_crystal_allday = new System.Windows.Forms.Label();
            this.l_metal_allday = new System.Windows.Forms.Label();
            this.b_dispatch = new System.Windows.Forms.Button();
            this.b_sysmap = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputArea
            // 
            this.outputArea.Enabled = false;
            this.outputArea.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outputArea.Location = new System.Drawing.Point(21, 533);
            this.outputArea.Multiline = true;
            this.outputArea.Name = "outputArea";
            this.outputArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputArea.Size = new System.Drawing.Size(1002, 114);
            this.outputArea.TabIndex = 1;
            // 
            // btnOverView
            // 
            this.btnOverView.Location = new System.Drawing.Point(21, 24);
            this.btnOverView.Name = "btnOverView";
            this.btnOverView.Size = new System.Drawing.Size(78, 42);
            this.btnOverView.TabIndex = 6;
            this.btnOverView.Text = "收集情报";
            this.btnOverView.UseVisualStyleBackColor = true;
            this.btnOverView.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(301, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "当前星球名称";
            // 
            // l_ballname
            // 
            this.l_ballname.AutoSize = true;
            this.l_ballname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_ballname.Location = new System.Drawing.Point(428, 71);
            this.l_ballname.Name = "l_ballname";
            this.l_ballname.Size = new System.Drawing.Size(0, 16);
            this.l_ballname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(303, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "金属存量";
            // 
            // l_metal
            // 
            this.l_metal.AutoSize = true;
            this.l_metal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_metal.Location = new System.Drawing.Point(387, 112);
            this.l_metal.Name = "l_metal";
            this.l_metal.Size = new System.Drawing.Size(0, 16);
            this.l_metal.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(303, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "金属仓库";
            // 
            // l_metalstroe
            // 
            this.l_metalstroe.AutoSize = true;
            this.l_metalstroe.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_metalstroe.Location = new System.Drawing.Point(387, 140);
            this.l_metalstroe.Name = "l_metalstroe";
            this.l_metalstroe.Size = new System.Drawing.Size(0, 16);
            this.l_metalstroe.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(506, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "晶体存量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(506, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "晶体仓库";
            // 
            // l_crystal
            // 
            this.l_crystal.AutoSize = true;
            this.l_crystal.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_crystal.Location = new System.Drawing.Point(596, 114);
            this.l_crystal.Name = "l_crystal";
            this.l_crystal.Size = new System.Drawing.Size(0, 16);
            this.l_crystal.TabIndex = 17;
            // 
            // l_crystalstore
            // 
            this.l_crystalstore.AutoSize = true;
            this.l_crystalstore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_crystalstore.Location = new System.Drawing.Point(596, 142);
            this.l_crystalstore.Name = "l_crystalstore";
            this.l_crystalstore.Size = new System.Drawing.Size(0, 16);
            this.l_crystalstore.TabIndex = 18;
            // 
            // l_hstore
            // 
            this.l_hstore.AutoSize = true;
            this.l_hstore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_hstore.Location = new System.Drawing.Point(795, 140);
            this.l_hstore.Name = "l_hstore";
            this.l_hstore.Size = new System.Drawing.Size(0, 16);
            this.l_hstore.TabIndex = 22;
            // 
            // l_h
            // 
            this.l_h.AutoSize = true;
            this.l_h.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_h.Location = new System.Drawing.Point(795, 112);
            this.l_h.Name = "l_h";
            this.l_h.Size = new System.Drawing.Size(0, 16);
            this.l_h.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(702, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "重氢仓库";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(702, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "重氢存量";
            // 
            // l_energystore
            // 
            this.l_energystore.AutoSize = true;
            this.l_energystore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_energystore.Location = new System.Drawing.Point(1001, 140);
            this.l_energystore.Name = "l_energystore";
            this.l_energystore.Size = new System.Drawing.Size(0, 16);
            this.l_energystore.TabIndex = 26;
            // 
            // l_energy
            // 
            this.l_energy.AutoSize = true;
            this.l_energy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_energy.Location = new System.Drawing.Point(1001, 112);
            this.l_energy.Name = "l_energy";
            this.l_energy.Size = new System.Drawing.Size(0, 16);
            this.l_energy.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Coral;
            this.label16.Location = new System.Drawing.Point(909, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "总能量";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Coral;
            this.label17.Location = new System.Drawing.Point(909, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 16);
            this.label17.TabIndex = 23;
            this.label17.Text = "当前能量";
            // 
            // lb_ball_list
            // 
            this.lb_ball_list.FormattingEnabled = true;
            this.lb_ball_list.ItemHeight = 12;
            this.lb_ball_list.Location = new System.Drawing.Point(21, 84);
            this.lb_ball_list.Name = "lb_ball_list";
            this.lb_ball_list.Size = new System.Drawing.Size(224, 340);
            this.lb_ball_list.TabIndex = 27;
            this.lb_ball_list.SelectedIndexChanged += new System.EventHandler(this.lb_balllist_SelectedIndexChanged);
            // 
            // l_metal_all
            // 
            this.l_metal_all.AutoSize = true;
            this.l_metal_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_metal_all.Location = new System.Drawing.Point(303, 248);
            this.l_metal_all.Name = "l_metal_all";
            this.l_metal_all.Size = new System.Drawing.Size(0, 16);
            this.l_metal_all.TabIndex = 28;
            // 
            // l_crystal_all
            // 
            this.l_crystal_all.AutoSize = true;
            this.l_crystal_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_crystal_all.Location = new System.Drawing.Point(440, 248);
            this.l_crystal_all.Name = "l_crystal_all";
            this.l_crystal_all.Size = new System.Drawing.Size(0, 16);
            this.l_crystal_all.TabIndex = 28;
            // 
            // l_H_all
            // 
            this.l_H_all.AutoSize = true;
            this.l_H_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_H_all.Location = new System.Drawing.Point(589, 248);
            this.l_H_all.Name = "l_H_all";
            this.l_H_all.Size = new System.Drawing.Size(0, 16);
            this.l_H_all.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(303, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "金属总量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Fuchsia;
            this.label10.Location = new System.Drawing.Point(440, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "晶体总量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(589, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "重氢总量";
            // 
            // noti
            // 
            this.noti.Icon = ((System.Drawing.Icon)(resources.GetObject("noti.Icon")));
            this.noti.Text = "银河农夫";
            this.noti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(589, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "重氢总产量(时）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(440, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "晶体总产量(时）";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(303, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "金属总产量(时）";
            // 
            // l_hh_all
            // 
            this.l_hh_all.AutoSize = true;
            this.l_hh_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_hh_all.Location = new System.Drawing.Point(589, 339);
            this.l_hh_all.Name = "l_hh_all";
            this.l_hh_all.Size = new System.Drawing.Size(0, 16);
            this.l_hh_all.TabIndex = 36;
            // 
            // l_crystalh_all
            // 
            this.l_crystalh_all.AutoSize = true;
            this.l_crystalh_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_crystalh_all.Location = new System.Drawing.Point(440, 339);
            this.l_crystalh_all.Name = "l_crystalh_all";
            this.l_crystalh_all.Size = new System.Drawing.Size(0, 16);
            this.l_crystalh_all.TabIndex = 35;
            // 
            // l_metalh_all
            // 
            this.l_metalh_all.AutoSize = true;
            this.l_metalh_all.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_metalh_all.Location = new System.Drawing.Point(303, 339);
            this.l_metalh_all.Name = "l_metalh_all";
            this.l_metalh_all.Size = new System.Drawing.Size(0, 16);
            this.l_metalh_all.TabIndex = 37;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(42, 487);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(951, 17);
            this.progressBar1.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(589, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 16);
            this.label14.TabIndex = 45;
            this.label14.Text = "重氢总产量(日）";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(440, 392);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 16);
            this.label15.TabIndex = 46;
            this.label15.Text = "晶体总产量(日）";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(303, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 16);
            this.label18.TabIndex = 47;
            this.label18.Text = "金属总产量(日）";
            // 
            // l_h_allday
            // 
            this.l_h_allday.AutoSize = true;
            this.l_h_allday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_h_allday.Location = new System.Drawing.Point(589, 424);
            this.l_h_allday.Name = "l_h_allday";
            this.l_h_allday.Size = new System.Drawing.Size(0, 16);
            this.l_h_allday.TabIndex = 43;
            // 
            // l_crystal_allday
            // 
            this.l_crystal_allday.AutoSize = true;
            this.l_crystal_allday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_crystal_allday.Location = new System.Drawing.Point(440, 424);
            this.l_crystal_allday.Name = "l_crystal_allday";
            this.l_crystal_allday.Size = new System.Drawing.Size(0, 16);
            this.l_crystal_allday.TabIndex = 42;
            // 
            // l_metal_allday
            // 
            this.l_metal_allday.AutoSize = true;
            this.l_metal_allday.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_metal_allday.Location = new System.Drawing.Point(303, 424);
            this.l_metal_allday.Name = "l_metal_allday";
            this.l_metal_allday.Size = new System.Drawing.Size(0, 16);
            this.l_metal_allday.TabIndex = 44;
            // 
            // b_dispatch
            // 
            this.b_dispatch.Location = new System.Drawing.Point(118, 24);
            this.b_dispatch.Name = "b_dispatch";
            this.b_dispatch.Size = new System.Drawing.Size(127, 42);
            this.b_dispatch.TabIndex = 48;
            this.b_dispatch.Text = "资源调度(开发中）";
            this.b_dispatch.UseVisualStyleBackColor = true;
            this.b_dispatch.Visible = false;
            this.b_dispatch.Click += new System.EventHandler(this.b_dispatch_Click);
            // 
            // b_sysmap
            // 
            this.b_sysmap.Location = new System.Drawing.Point(268, 24);
            this.b_sysmap.Name = "b_sysmap";
            this.b_sysmap.Size = new System.Drawing.Size(78, 42);
            this.b_sysmap.TabIndex = 49;
            this.b_sysmap.Text = "星系图";
            this.b_sysmap.UseVisualStyleBackColor = true;
            this.b_sysmap.Click += new System.EventHandler(this.b_sysmap_Click);
            // 
            // btnRank
            // 
            this.btnRank.Location = new System.Drawing.Point(375, 24);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(78, 42);
            this.btnRank.TabIndex = 50;
            this.btnRank.Text = "死羊分析";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.b_rank_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 661);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.b_sysmap);
            this.Controls.Add(this.b_dispatch);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.l_h_allday);
            this.Controls.Add(this.l_crystal_allday);
            this.Controls.Add(this.l_metal_allday);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.l_hh_all);
            this.Controls.Add(this.l_crystalh_all);
            this.Controls.Add(this.l_metalh_all);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.l_H_all);
            this.Controls.Add(this.l_crystal_all);
            this.Controls.Add(this.l_metal_all);
            this.Controls.Add(this.lb_ball_list);
            this.Controls.Add(this.l_energystore);
            this.Controls.Add(this.l_energy);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.l_hstore);
            this.Controls.Add(this.l_h);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.l_crystalstore);
            this.Controls.Add(this.l_crystal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_metalstroe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_metal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_ballname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOverView);
            this.Controls.Add(this.outputArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "银河农夫 - 概况";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputArea;
        private System.Windows.Forms.Button btnOverView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_ballname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_metal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_metalstroe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_crystal;
        private System.Windows.Forms.Label l_crystalstore;
        private System.Windows.Forms.Label l_hstore;
        private System.Windows.Forms.Label l_h;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_energystore;
        private System.Windows.Forms.Label l_energy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lb_ball_list;
        private System.Windows.Forms.Label l_metal_all;
        private System.Windows.Forms.Label l_crystal_all;
        private System.Windows.Forms.Label l_H_all;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NotifyIcon noti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_hh_all;
        private System.Windows.Forms.Label l_crystalh_all;
        private System.Windows.Forms.Label l_metalh_all;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label l_h_allday;
        private System.Windows.Forms.Label l_crystal_allday;
        private System.Windows.Forms.Label l_metal_allday;
        private System.Windows.Forms.Button b_dispatch;
        private System.Windows.Forms.Button b_sysmap;
        private System.Windows.Forms.Button btnRank;
    }
}

