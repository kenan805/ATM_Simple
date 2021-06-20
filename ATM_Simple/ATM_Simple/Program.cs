using System;

namespace ATM_Simple
{
    class Program
    {
        static void Start()
        {
            Console.Title = "Bank";
            Bank bank = new()
            {
                Name = "Kapital bank"
            };

            Bankcard bankcard1 = new Bankcard(1, "Kapital bank", "KANAN IDAYATOV", "5103 0714 6533 3322", "1111");
            Bankcard bankcard2 = new Bankcard(2, "Kapital bank", "NEBI NEBILI", "5103 0714 3422 8712", "2222");
            Bankcard bankcard3 = new Bankcard(3, "Kapital bank", "RAHIM ALIYEV", "5103 0714 2131 1231", "0909");

            Client client1 = new Client(1, "Kenan", "Idayatov", 19, 1500, bankcard1);
            Client client2 = new Client(2, "Nebi", "Nebili", 19, 1800, bankcard2);
            Client client3 = new Client(3, "Rahim", "Aliyev", 22, 2200, bankcard3);
            bank.AddClient(client1);
            bank.AddClient(client2);
            bank.AddClient(client3);

            bank.ShowAllClientsInfo();
            bank.ShowAllCardsInfo();
            bank.ShowCardBalance(bankcard1);
        }
        static void Main(string[] args)
        {
            Start();


        }
    }
}


