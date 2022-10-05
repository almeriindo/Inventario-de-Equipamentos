using DetranApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DetranApp.DB
{
    internal class MongoDBConnection
    {
        private MongoClient dbClient;
        private List<EquipamentoTeste> l;

        public MongoDBConnection()
        {
            this.dbClient = new MongoClient("mongodb+srv://detranteste:teste@detran.iwghfjw.mongodb.net/?retryWrites=true&w=majority");
        }

        
        /*
        public List<EquipamentoTeste> GetAllEquipaments()
        {
           this.l = dbClient.ListDatabases().ToList();

            return this.l;
        }
        */
    }
}
