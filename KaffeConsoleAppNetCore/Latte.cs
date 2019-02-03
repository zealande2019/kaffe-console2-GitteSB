﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class Latte : kaffe , Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal bruges til Latte
        /// </summary>
        /// <returns></returns>
        public int MlMælk => 120;

        public override int Pris()
        {
            return 40;
        }

        public override string Styrke()
        {
            return base.Styrke();
        }

        internal override string Styrke(object mild)
        {
            throw new NotImplementedException();
        }
    }
}
