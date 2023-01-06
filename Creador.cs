using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public  class Creador // Esta clase crea objetos
    {
        public const int TRESLECHES = 1;
        public const int SELVANEGRA = 2;

        public static Pasteles CreadorPasteles (int tipo)
        {
            switch (tipo)
            {
                case TRESLECHES:
                    return new TresLeches();
                 case SELVANEGRA:
                    return new SelvaNegra();
                default: return null;
            }


        }

    }
}
