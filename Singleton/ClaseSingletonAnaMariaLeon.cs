using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ClaseSingletonAnaMariaLeon
    {
        private static ClaseSingletonAnaMariaLeon instance = null;
        public string mensaje="";

        protected ClaseSingletonAnaMariaLeon()
        {
            mensaje = "Hola soy Anita";
        }

        public static ClaseSingletonAnaMariaLeon Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClaseSingletonAnaMariaLeon();

                return instance;
            }
        }

    }
}
