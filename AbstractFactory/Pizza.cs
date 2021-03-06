﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        /// <summary>
        /// 名稱
        /// </summary>
        public string name;

        /// <summary>
        /// 麵團
        /// </summary>
        protected Dough dough;

        /// <summary>
        /// 醬料
        /// </summary>
        protected Sauce sauce;

        /// <summary>
        /// 起司
        /// </summary>
        protected Cheese cheese;

        /// <summary>
        /// 準備
        /// </summary>
        public virtual void Prepare()
        {
            Console.WriteLine("Standard preparation technique.");
        }

        /// <summary>
        /// 烘培
        /// </summary>
        public virtual void Bake()
        {
            Console.WriteLine("Standard baking technique.");
        }

        /// <summary>
        /// 裁切
        /// </summary>
        public virtual void Cut()
        {
            Console.WriteLine("Standard cutting technique.");
        }

        /// <summary>
        /// 裝箱
        /// </summary>
        public virtual void Box()
        {
            Console.WriteLine("Standard boxing technique.");
        }
    }
}
