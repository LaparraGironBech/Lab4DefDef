using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4DefDef.Models.Data
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Creador> CreadorList;
        private Singleton()
        {
            CreadorList = new List<Creador>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
