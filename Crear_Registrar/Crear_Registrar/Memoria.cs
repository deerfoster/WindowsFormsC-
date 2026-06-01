using System;
using System.Collections.Generic;
using System.Text;
using static Crear_Registrar.registro;

namespace Crear_Registrar
{
    internal class MemoriaClase
    {
        //Singleton//
        public class Memoria
        {
            private static Memoria instancia;

            public List<Registro> listaRegistros { get; set; }

            private Memoria()
            {
                listaRegistros = new List<Registro>();
            }

            public static Memoria Instancia
            {
                get
                {
                    if (instancia == null)
                    {
                        instancia = new Memoria();
                    }
                    return instancia;
                }
            }
        }
    }
}
