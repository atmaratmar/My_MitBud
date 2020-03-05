using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using My_MitBud.DAL;
using My_MitBud.Models;

namespace My_MitBud.Providers
{
    public class ClientProvider
    {
        public static void SaveClientInfo(RegisterClient registerViewModel, string UserId)
        {
            MitBudDBEntities db = new MitBudDBEntities();
            Client client = new Client();
            client.Client_Id = UserId;
            client.Name = registerViewModel.Name;
            client.Email = registerViewModel.Email;

            db.Clients.Add(client);
            db.SaveChanges();


        }
    }
}