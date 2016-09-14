using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib {
    public class DepositDecorator: DecoratorBase {
        private int _deposit;

        public DepositDecorator(CustomerComponent component) : base(component) {
            _services = "deposit";
            _monthlyFee = 0;
            Interest = 5;
            Maturity = 3;
        }

        public int Maturity { get; set; }

        public int Interest { get; set; }
        public int Deposit { get { return _deposit; } }

        public bool CreateDeposit(int value) {
            if (value <= _amount) {
                _deposit = value;
                _amount -= value;
                return true;
            }
            return false;
        }

        public void CloseDeposit() {
            _amount += _deposit;
            _deposit = 0;
        }

        public bool CheckMaturity(int time) {
            if (time >= Maturity) {
                _deposit = _deposit*(100 + Interest)/100;
                return true;
            }
            return false;
        }
    }
}
