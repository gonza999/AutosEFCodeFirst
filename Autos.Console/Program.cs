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
            //SetCategoriasIdEnVendedores();
            //SetAutoIdEnVentas();
            //SetMontoEnVentas();
            System.Console.ReadLine();
        }

        private static void SetMontoEnVentas()
        {
            using (var context=new AutosDbContext())
            {
                var ventas = context.Ventas.ToList();
                foreach (var v in ventas)
                {
                    var auto = context.Autos.FirstOrDefault(a => a.AutoId == v.AutoId);
                    v.Monto = auto.PrecioFinal;
                }

                context.SaveChanges();
                System.Console.WriteLine("Actualizaciones de monto realizadas con exito");
            }
        }

        private static void SetAutoIdEnVentas()
        {
            using (var context = new AutosDbContext())
            {
                var autos = context.Autos.ToList();
                var ventas = context.Ventas.ToList();
                Random r = new Random();
                foreach (var v in ventas)
                {
                    int posicion = r.Next(1,autos.Count());
                    var auto = autos[posicion];
                    v.AutoId = auto.AutoId;
                }

                context.SaveChanges();
                System.Console.WriteLine("Cambios completados!");
            }
        }

        //private static void SetCategoriasIdEnVendedores()
        //{
        //    using (var context=new AutosDbContext())
        //    {
        //        var senior = context.CategoriasDeVendedores.FirstOrDefault(cv => cv.Descripcion == "Senior");
        //        var junior = context.CategoriasDeVendedores.FirstOrDefault(cv => cv.Descripcion == "Junior");
        //        var vendedores = context.Vendedores.ToList();
        //        foreach (var v in vendedores)
        //        {
        //            if (v.Categoria=="Senior")
        //            {
        //                v.CategoriaDeVendedorId = senior.CategoriaDeVendedorId;
        //            }

        //            if (v.Categoria=="Junior")
        //            {
        //                v.CategoriaDeVendedorId = junior.CategoriaDeVendedorId;
        //            }
        //        }

        //        context.SaveChanges();
        //        System.Console.WriteLine("Cambios realizados con exito!");
        //    }
        //}
    }
}
