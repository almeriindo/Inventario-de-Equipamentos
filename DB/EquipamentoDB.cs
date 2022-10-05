using MongoDB.Driver;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetranApp.DB
{
    public class EquipamentoDB
    {
        public String DataBaseName = "Equipamentos";
        private string conexaoMongoDB = "mongodb+srv://detranteste:teste@detran.iwghfjw.mongodb.net/?retryWrites=true&w=majority";
    }
}
