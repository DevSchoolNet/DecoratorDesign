using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib {
    public class AccountDecorator: DecoratorBase {
        public AccountDecorator(CustomerComponent component) : base(component) {
            _services = "accout";
            _monthlyFee = 1;
        }

        public string Iban { get; set; }

        public void AddMoney(int value) {
            _amount += value;
        }

        public bool Payment(int value) {
            if (value <= _amount) {
                _amount -= value;
                return true;
            }
            return false;
        }
    }
}
