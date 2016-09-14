using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLib {
    public abstract class CustomerComponent {
        public abstract string Name { get; }
        public abstract string Cui { get; }
        public abstract int Amount { get; }
        public abstract string Services { get; }
        public abstract int MonthlyFee { get; }
        protected abstract void SetAmount(int amount);
    }
}
