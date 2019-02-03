using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class Cortado : kaffe , Imælk
    {
        /// <summary>
        /// hvor meget mælk skal bruge i cortado
        /// </summary>
        /// <returns></returns>
        public int MlMælk => 25;

        /// <summary>
        /// Prisen på Cortado
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            return 25;
        }

        internal override string Styrke(object mild)
        {
            throw new NotImplementedException();
        }
    }
}
