using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name="Jose", LastName="Perez" },
                new Client {Name="Juan", LastName="Perez" },
                new Client {Name="Pedro", LastName="Perez" },
                new Client {Name="Alan", LastName="Perez" },
                new Client {Name="Roberto", LastName="Perez" },
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

        }
    }
}
