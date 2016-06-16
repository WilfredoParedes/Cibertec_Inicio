using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData: BaseDataAccess<Client>
    {
       public Client GetClient(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Clients.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
