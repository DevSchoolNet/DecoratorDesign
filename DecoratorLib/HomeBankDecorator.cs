using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib {
    public class HomeBankDecorator: DecoratorBase {
        public HomeBankDecorator(CustomerComponent component) : base(component) {
            _services = "home bank";
            _monthlyFee = 4;
        }
    }
}
