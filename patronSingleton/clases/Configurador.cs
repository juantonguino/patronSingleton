using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace patronSingleton.clases
{
    public class Configurador
    {
        private String url;
        private String baseDatos;
        private static Configurador instancia;
        private static String mensaje;

        private Configurador(String url, String baseDatos)
        {
            this.url = url;
            this.baseDatos = baseDatos;
        }
        
        public static Configurador darInstancia(String url, String baseDatos){
            if (instancia == null)
            {
                instancia = new Configurador(url, baseDatos);
                mensaje = "es la primera vez ques se crea este configurador";
                return instancia;
            }
            else
            {
                mensaje = "este objeto ya ha sido instanciado";
                return instancia;
            }
        }
        public static String darMensaje()
        {
            return mensaje;
        }
    }
}