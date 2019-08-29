using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipos_de_beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo toros =                                 //Declaración de la variable nueva
                new Equipo("Toros");
            Equipo pumas =
                new Equipo("Pumas");

            equipos.Add(toros);
            equipos.Add(pumas);

            Jugador pedro = new Jugador("Pedro", "12");
            Jugador juan = new Jugador("Juan", "99");
            Jugador jose = new Jugador("Jose", "24");
            Jugador miguel = new Jugador("Miguel", "57");
            Jugador pablo = new Jugador("Pablo", "01");
            Jugador ramon = new Jugador("Ramon", "10");
            Jugador antonio = new Jugador("Antonio", "09");
            Jugador alfredo = new Jugador("Alfredo", "77");
            Jugador enrique = new Jugador("Enrique", "45");

            Jugador francisco = new Jugador("Francisco", "11");
            Jugador angel = new Jugador("Angel", "05");
            Jugador alonso = new Jugador("Alonso", "39");
            Jugador alejandro = new Jugador("Alejandro", "98");
            Jugador adrian = new Jugador("Adrian", "80");
            Jugador kevin = new Jugador("Kevin", "15");
            Jugador manuel = new Jugador("Manuel", "23");
            Jugador ivan = new Jugador("ivan", "67");
            Jugador david = new Jugador("David", "26");

            toros.Jugadores.Add(pedro);
            toros.Jugadores.Add(juan);
            toros.Jugadores.Add(jose);
            toros.Jugadores.Add(miguel);
            toros.Jugadores.Add(pablo);
            toros.Jugadores.Add(ramon);
            toros.Jugadores.Add(antonio);
            toros.Jugadores.Add(alfredo);
            toros.Jugadores.Add(enrique);

            pumas.Jugadores.Add(francisco);
            pumas.Jugadores.Add(angel);
            pumas.Jugadores.Add(alonso);
            pumas.Jugadores.Add(alejandro);
            pumas.Jugadores.Add(adrian);
            pumas.Jugadores.Add(kevin);
            pumas.Jugadores.Add(manuel);
            pumas.Jugadores.Add(ivan);
            pumas.Jugadores.Add(david);


            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " +
                    equipo.Nombre);
                Console.WriteLine("Lista de jugadores: ");
                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("*" +
                       jugador.NombreJug);
                    Console.WriteLine("" +
                       jugador.Numero);
                }
            }

            Console.Read();
        }
    }
}
