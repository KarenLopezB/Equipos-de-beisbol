using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_beisbol
{
    class Jugador
    {
        public string NombreJug { get; set; }
        public string Numero { get; set; }

        public Jugador()
        {
            NombreJug = "Pendiente";
            Numero = "Sin asignar";
        }

        public Jugador(string nombrejug, string numero)
        {
            NombreJug = nombrejug;
            Numero = numero;
        }
    }
}
