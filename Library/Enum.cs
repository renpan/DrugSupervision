using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrugSupervise.Library
{
    public enum PackFlag : int
    {
        正常, 拼箱, 零箱, 即拼箱又零箱
    }

    public enum PackLayer : int
    {
        一级包装, 二级包装, 三级包装, 四级包装, 五级包装, 六级包装, 七级包装, 八级包装, 九级包装, 十级包装
    }
}
