using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class TresLeches : Pasteles
    {
        public override int pastelesSemanales()
        {
            return 5;
        }
    }
}
