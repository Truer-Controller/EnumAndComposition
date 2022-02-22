using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndComposition.Entities
{
    class Client
    {
        public string NameClient { get; set; }
        public string MailClient { get; set; }
        public DateTime BirthDateClient { get; set; }

        public Client()
        {
        }

        public Client(string nameClient, string mailClient, DateTime birthDateClient)
        {
            NameClient = nameClient;
            MailClient = mailClient;
            BirthDateClient = birthDateClient;
        }
        public override string ToString()
        {
            return NameClient
                + ", ("
                + BirthDateClient.ToString("dd/MM/yyyy")
                + ") - "
                + MailClient;
        }
    }
}
