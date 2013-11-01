using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DrugSupervise.Library
{
    public class DrugBox
    {
        private string barcode;
        /// <summary>
        /// 包装上的条形码
        /// </summary>
        public string Barcode
        {
            get { return barcode; }
            set
            {
                HasBarcode = (value != string.Empty);
                barcode = value;
            }
        }

        /// <summary>
        /// 包装所在层级（由0开始）
        /// </summary>
        public int Layer
        { get; private set; }

        /// <summary>
        /// 包装状态
        /// </summary>
        public int State
        { get; set; }

        /// <summary>
        /// 包装是否已经具有条形码
        /// </summary>
        public bool HasBarcode
        { get; private set; }

        private PackFlag flag;
        /// <summary>
        /// 特殊包装标记
        /// </summary>
        public PackFlag Flag
        {
            get
            { return flag; }
            set
            {
                flag = value;
                if (value != PackFlag.正常)
                {
                    if (Parent != null) Parent.Flag = value;
                }
            }
        }

        /// <summary>
        /// 当前包装内的子包装
        /// </summary>
        public IList<DrugBox> Child
        { get; set; }

        /// <summary>
        /// 当前包装的上一级包装
        /// </summary>
        public DrugBox Parent
        { get; set; }

        /// <summary>
        /// 生成一个位于指定层次的包装
        /// </summary>
        /// <param name="layer"></param>
        public DrugBox(int layer)
            : this(string.Empty, layer)
        { }
        /// <summary>
        /// 生成一个具有指定条码和层次的包装
        /// </summary>
        /// <param name="barcode">指定的条码</param>
        /// <param name="layer">指定的包装层次</param>
        public DrugBox(string barcode, int layer)
        {
            Layer = layer;
            Barcode = barcode;
            if (layer != 0)
                Child = new List<DrugBox>();
            else
                Child = null;
            Parent = null;
        }
        /// <summary>
        /// 将此实例转化成等效的字符串表示形式
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (HasBarcode) ? barcode : string.Format("无条码的{0}级包装", Layer + 1);
        }

    }
}
