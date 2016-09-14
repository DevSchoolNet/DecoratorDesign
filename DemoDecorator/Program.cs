using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorLib;

namespace DemoDecorator {
    class Program {
        static void Main(string[] args) {
            var customer = new CustomerBase("John", "1234");

            var homeBankCustomer = new HomeBankDecorator(customer);

            var accoutCustomer = new AccountDecorator(customer);

            var accoutHomeBankCustomer = new AccountDecorator(homeBankCustomer);
            accoutHomeBankCustomer.Iban = "1234";
            accoutHomeBankCustomer.AddMoney(4000);
            var status = accoutHomeBankCustomer.Payment(1200);
            status = accoutHomeBankCustomer.Payment(5000);

            var depositCustomer = new DepositDecorator(accoutHomeBankCustomer);
            status = depositCustomer.CreateDeposit(800);
            status = depositCustomer.CheckMaturity(1);
            status = depositCustomer.CheckMaturity(3);
            status = depositCustomer.CheckMaturity(4);
            depositCustomer.CloseDeposit();
        }
    }
}
