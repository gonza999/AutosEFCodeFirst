using Autos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context=new AutosDbContext())
            {
                var lista = context.Autos.ToList();
                foreach (var a in lista)
                {
                    System.Console.WriteLine($"{a.Marca.NombreMarca},{a.Modelo},{a.TipoDeVehiculo.Descripcion}");
                }
            }

            System.Console.ReadLine();
        }
    }
}
