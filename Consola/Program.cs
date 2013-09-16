using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola
{
    class Programa
    {

       
        public  void Reloj()
        {
            
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            Console.WriteLine("Hora actual:\n " + h.ToString("00:")+ m.ToString("00:")+ s.ToString("00"));

           // Console.WriteLine("Hora actual:\n " + DateTime.Now.ToShortTimeString()) // muestra la hora actual con tan solo una línea
            Console.Read();
          
            
        }

        public  void Cronometro()
        {


            for (int horas = 00; horas < 60; horas++)
            {
                for (int minutos = 00; minutos < 60; minutos++)
                {

                    for (int segundos = 00; segundos < 60; segundos++)
                    {


                        Console.WriteLine(horas.ToString("00:") + minutos.ToString("00:")+segundos.ToString("00"));

                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
            }
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("MENU\n1-Reloj\n2-Cronómetro");
           
           Programa pg = new Programa();
           int opc= int.Parse(Console.ReadLine());
           System.Console.Clear(); 
                 
         switch (opc)
            {

                case 1:
                    Console.WriteLine("Reloj");
                    System.Console.Clear(); 
                    pg.Reloj();
                    break;

                case 2:
                    Console.WriteLine("Cronómetro");
                    pg.Cronometro();
                    break;

                  
                default: 
                    Console.WriteLine("esta opcion no existe, favor ingrese otro numero");
                    Console.Read();
                    break;


            }
        } 
    }
}