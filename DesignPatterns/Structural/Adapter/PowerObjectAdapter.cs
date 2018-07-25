using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// 对象的适配器模式，可以适配一个类型及其子类型。
    /// </summary>
    public class PowerObjectAdapter : ITwoLeggedPlug
    {
        private readonly ThreeLeggedPlug _threeLeggedPlug;

        public PowerObjectAdapter(ThreeLeggedPlug threeLeggedPlug)
        {
            this._threeLeggedPlug = threeLeggedPlug;
        }

        public string Description => $"A three legged plug produced by {this._threeLeggedPlug.Brand}";
    }
}
