using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib {
    public class DecoratorBase: CustomerComponent {
        protected int _amount;
        //private string _name;
        //private string _cui;
        protected string _services;
        private CustomerComponent _component;
        protected int _monthlyFee;

        public DecoratorBase(CustomerComponent component) {
            _component = component;
            _amount = component.Amount;
        }

        public CustomerComponent InnerComponent { get { return _component; } }
        public override string Name { get { return _component.Name; } }
        public override string Cui { get { return _component.Cui; } }
        public override string Services { get { return string.Format("{0} with {1}", _component.Services, _services); } }
        public override int MonthlyFee { get { return _component.MonthlyFee + _monthlyFee; } }
        protected override void SetAmount(int amount) {
            _amount = amount;
        }

        public override int Amount {
            get { return _amount; }
        }
    }
}
