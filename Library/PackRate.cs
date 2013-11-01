using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrugSupervise.Library
{
    public struct PackRate
    {
        private int[] capacity;
        private string[] rate;
        private int level;
        /// <summary>
        /// 包装层级
        /// </summary>
        public int Level
        {
            get { return level; }
        }
        /// <summary>
        /// 使用指定的包装比例字符串形成包装比例
        /// </summary>
        /// <param name="rateString">包装比例字符串，以‘：’分隔符</param>
        public PackRate(string rateString)
        {
            rate = rateString.Split(':');
            level = rate.Length;
            capacity = new int[rate.Length];
            for (int i = 0; i <= level - 1; i++)
            {
                capacity[i] = int.Parse(rate[level - 1 - i]);
            }
            //计算所有包装内子包装的数量
            for (int i = 0; i <= level - 2; i++)
            {
                capacity[i] /= capacity[i + 1];
            }

        }
        /// <summary>
        /// 返回形成上层包装的当前层次上的数量
        /// </summary>
        /// <param name="index">包装层次：0最小包装 1中等包装 2大包装</param>
        /// <returns>形成上层包装的当前层次上的数量</returns>
        public int this[int index]
        {
            get
            { return capacity[index]; }
        }
        /// <summary>
        /// 返回包装比例
        /// </summary>
        /// <returns>包装比例</returns>
        public override string ToString()
        {
            return ToString(":");
        }
        /// <summary>
        /// 返回包装比例，并使用指定字符分隔
        /// </summary>
        /// <param name="splitor"></param>
        /// <returns>用指定分隔符分隔的包装比例</returns>
        public string ToString(string splitor)
        {
            return string.Join(splitor, rate);
        }
    }
}
