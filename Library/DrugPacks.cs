using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrugSupervise.Library
{
    public class DrugPacks
    {
        Dictionary<int, List<DrugBox>> packs;
        private PackRate rackRate;
        /// <summary>
        /// 包装集群所使用的包装比例
        /// </summary>
        public PackRate PackRate
        {
            get { return rackRate; }
        }
        /// <summary>
        /// 本包装集群所使用的包装层次
        /// </summary>
        public int Level
        {
            get { return rackRate.Level; }
        }
        /// <summary>
        /// 使用指定的包装比例形成一个包装集群
        /// </summary>
        /// <param name="rate">包装比例</param>
        public DrugPacks(PackRate rate)
        {
            rackRate = rate;
            packs = new Dictionary<int, List<DrugBox>>();
            for (int i = 0; i < rate.Level; i++)
            {
                packs.Add(i, new List<DrugBox>());
            }
        }
        /// <summary>
        /// 返回指定层次上的包装条码列表
        /// </summary>
        /// <param name="levelIndex">包装层次索引</param>
        /// <returns>包装条码的列表</returns>
        public List<DrugBox> this[int levelIndex]
        {
            get { return packs[levelIndex]; }
        }
        /// <summary>
        /// 添加一个新的包装
        /// </summary>
        /// <param name="layer">包装所在的层次（由0开始）</param>
        /// <param name="code">包装的条码</param>
        public void Add(int layer, DrugBox code)
        {
            if (packs.Keys.Contains(layer))
            {

                if (packs[layer].Count % PackRate[layer] == 0)
                {
                    if (packs.Keys.Contains(layer + 1))
                    {
                        Add(layer + 1, new DrugBox(layer + 1));
                    }
                }
                packs[layer].Add(code);
                if (packs.Keys.Contains(layer + 1))
                {
                    packs[layer].Last().Parent = packs[layer + 1].Last();
                    packs[layer].Last().Parent.Child.Add(packs[layer].Last());
                }
            }
        }
    }
}
