using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simple
{
    class Bank
    {
        public Client[] Clients { get; set; }
        public string Name { get; set; }

        public void AddClient(in Client newClient)
        {
            int count = (Clients == null) ? 1 : Clients.Length + 1;
            Client[] newClients = new Client[count];
            if (Clients != null) Array.Copy(Clients, newClients, Clients.Length);
            newClients[count - 1] = newClient;
            Clients = newClients;
        }

        public void ShowCardBalance(in Bankcard bankcard)
        {
            bankcard.ShowBalance();

        }
        public void ShowAllCardsInfo()
        {
            Console.WriteLine("\t\t\tAll cards info");
            foreach (var client in Clients)
            {
                client.BankAccount.ShowCardInfo();
            }
        }
        public void ShowAllClientsInfo()
        {
            Console.WriteLine("\t\t\tAll clients info");
            foreach (var client in Clients)
            {
                client.ShowClientInfo();
            }
        }
    }
}
