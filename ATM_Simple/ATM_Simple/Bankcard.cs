using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simple
{
    class Bankcard
    {
        public int Id { get; set; }
        public string Bankname { get; set; }
        public string Fullname { get; set; }
        public string PAN { get; set; }
        public string PIN { get; set; }
        public string CVC { get; set; }
        public double Balance { get; set; }
        public DateTime ExpireDate { get; set; }
        public Bankcard(int id,string bankname, string fullname, string pAN, string pIN)
        {
            Id = id;
            Bankname = bankname;
            Fullname = fullname;
            PAN = pAN;
            PIN = pIN;
            CVC = RandomCVC();
            Balance = RandomBalance();
            ExpireDate = RandomDate();
        }

        public void ShowCardInfo()
        {
            Console.WriteLine($"Bankname: {Bankname}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"PAN: {PAN}");
            Console.WriteLine($"PIN: {PIN}");
            Console.WriteLine($"CVC: {CVC}");
            Console.WriteLine($"Balance: {Balance}");
            if (ExpireDate.Month >= 1 && ExpireDate.Month <= 9)
                Console.WriteLine($"Expire date: 0{ExpireDate.Month}/{ExpireDate.Year % 100}");
            else
                Console.WriteLine($"Expire date: {ExpireDate.Month}/{ExpireDate.Year % 100}");
            Console.WriteLine();
        }
        public void ShowBalance()
        {
            Console.Write($"Card id: {Id}\nEnter password: ");
            string password = Console.ReadLine();
            if (password == PIN)
            {
                Console.WriteLine($"Card balance: {Balance} ");
            }
            else Console.WriteLine("The password is incorrect!");
        }

        public double RandomBalance()
        {
            Random random = new();
            double balance = random.Next(10, 450) + random.NextDouble();
            balance = (Convert.ToInt32(balance * 100));
            balance /= 100;
            return balance;
        }

        public DateTime RandomDate()
        {
            Random random = new();
            DateTime date = new(random.Next(2022, 2035), random.Next(1, 13), 1);
            return date;

        }

        public string RandomCVC()
        {
            Random random = new();
            int cvc = random.Next(100, 999);
            return cvc.ToString();
        }

    }
}
