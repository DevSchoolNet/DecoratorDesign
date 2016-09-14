using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib {
    public class CustomerBase: CustomerComponent {
        private int _amount;
        private string _name;
        private string _cui;
        private string _services;
        private int _monthlyFee;

        public CustomerBase(string name, string cui) {
            _name = name;
            _cui = cui;
            _services = name + " as customer";
        }
        public override string Name { get { return _name; } }
        public override string Cui { get { return _cui; } }
        public override string Services { get { return _services; } }
        public override int MonthlyFee { get { return _monthlyFee; } }

        public override int Amount {
            get { return _amount; }
        }


        protected override void SetAmount(int amount) {
            _amount = amount;
        }
    }
}
