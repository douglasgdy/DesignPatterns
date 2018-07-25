using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// 类的适配器模式，每次只能适配一个不兼容类型。
    /// </summary>
    public class PowerClassAdapter : BBrandThreeLeggedPlug, ITwoLeggedPlug
    {
        public string Description => $"A three legged plug produced by {base.Brand}";
    }
}
