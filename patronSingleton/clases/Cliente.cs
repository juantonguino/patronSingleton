using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patronSingleton.clases
{
    
    class Cliente
    {
        public Configurador con;
        
        public Cliente()
        {
            con = Configurador.darInstancia("","");
        }

        public String darMensaje()
        {
            return Configurador.darMensaje();
        }

    }
}
