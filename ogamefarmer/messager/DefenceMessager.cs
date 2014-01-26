﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalaxyFarmer
{
    class DefenceMessager : Messager
    {
        internal DefenceStrategy.DefenceType defenceType;

        /// <summary>
        /// 金属上限
        /// </summary>
        internal int MetalCapacity;
        /// <summary>
        /// 晶体上限
        /// </summary>
        internal int CrystalCapacity;
        /// <summary>
        /// 重氢上限
        /// </summary>
        internal int HHCapacity;

        /// <summary>
        /// 比例 分子
        /// </summary>
        internal double RatioNumerator;
        /// <summary>
        /// 比例 分母
        /// </summary>
        internal double RatioDenominator;

        internal int Progress = 0;
        internal bool IsBuilding = false;

        public int Fmenge401;
        public int Fmenge402;
        public int Fmenge405;
        public int Fmenge406;
        public bool IsScaning;
        public string Ballname;
        
        internal String PostBuildLog()
        {
            if (IsScaning)
            {
                return "正在扫描->" + Ballname + "\n";
            }
            if (IsBuilding)
            {
                return "在星球《" + Ballname + "》上一共建造了 火箭发射装置:" + Fmenge401 + "个;轻型激光炮:" + Fmenge402 + "个;中子炮:" + Fmenge405 + "个;等离子炮:" + Fmenge406 + "个\n";
            }
            return string.Empty;
        }
    }
}
