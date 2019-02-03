using System;
using System.Collections.Generic;
using System.Text;

namespace kaffe
{
    public class WhiteFlat : kaffe, Imælk
    {
        //hvor meget mælk skal bruges 160 mL
        public int MlMælk => 160;

        // hvad prisen skal være, den skal override default prisen
        public override int Pris()
        {
            return 45;
        }

        // Hvad styrken skal være, denne skal sættes til mild i stedet for stærk.
        public override string Styrke()
        {
            return "Mild";
        }

        internal override string Styrke(object mild)
        {
            throw new NotImplementedException();
        }
    }
}


