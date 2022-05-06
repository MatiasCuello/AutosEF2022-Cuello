using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutosEF2022.Context;

namespace AutosEF2022.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new AutosDbContext())
            {
                var lista = context.Autos.ToList();
                foreach (var auto in lista)
                {
                    Console.WriteLine($"{auto.Modelo}");
                }

                Console.ReadLine();
            }
        }
    }
}
