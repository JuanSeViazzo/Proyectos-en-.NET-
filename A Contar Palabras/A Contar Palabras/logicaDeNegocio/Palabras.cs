using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace logicaDeNegocio
{
    public class Palabras
    {

        static Dictionary<string, int> palabrasrepetidas = new Dictionary<string, int>();



        public static void AgregarPalabra(string palabra)
        {
            List<string> lista = palabra.Split(' ').ToList();

            {


                foreach (var item in lista)
                {
                    if (!palabrasrepetidas.ContainsKey(item))
                    {
                        palabrasrepetidas.Add(item, 1);

                            
                    }
                    else
                    {
                        palabrasrepetidas[item] +=1;
                    }
                }

            }

        }



        //public void Ordenar(Dictionary keyValuePair)
        //{
        //    Dict.Sort();
        //}







        /*  comidasLatinomaericanas.Add("empanadas", "Argentina");
​
            foreach (KeyValuePair<string, string> item in comidasLatinomaericanas)
            {
                if (item.Value == "Argentina")
                {
                    Console.WriteLine($"El plato {item.Key} pertenece a {item.Value}");
                }
            }
​
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Recorro las Keys");
            foreach (string item in comidasLatinomaericanas.Keys)
            {
                Console.WriteLine(item);
            }
​
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Recorro los Values");
            foreach (string item in comidasLatinomaericanas.Values)
            {
                Console.WriteLine(item);
            }*/


    }
}
