using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class TV
    {
        private readonly string _brand;
        private bool _isOpened;
        private int _channel;

        public TV(string brand)
        {
            this._brand = brand;
        }

        public string Brand => _brand;
        public bool IsOpened => _isOpened;
        public int Channel => _channel;

        public void Open()
        {
            this._isOpened = true;
            Console.WriteLine($"Open {this.Brand} TV...");
        }

        public void Close()
        {
            this._isOpened = false;
            Console.WriteLine($"Close {this.Brand} TV...");
        }

        public void Switch(int channel)
        {
            this._channel = channel;
            Console.WriteLine($"Switch channel to {this.Channel} on {this.Brand} TV...");
        }
    }
}
