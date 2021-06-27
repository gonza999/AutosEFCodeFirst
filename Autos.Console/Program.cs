using Autos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autos.Entities;

namespace Autos.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //SetCategoriasIdEnVendedores();
            //SetAutoIdEnVentas();
            //SetMontoEnVentas();
            //SetCominsionEnVentas();
            //AddSucursales();
            //SetSucursalIdEnVentas();
            //SetPaisDeOrigenIdEnAutos();
            //SetLocalidadIdYProvinciaIdEnClientes();
            //AddSituacionesIva();
            //SetSituacionesIdEnClientes();
            //ListarAutosFiltradosPorMarca();
            //ListarLos3AutosMasCarosFiltradosPorPais();
            //ListarLasComisionesPorVendedor();
            System.Console.ReadLine();
        }

        private static void ListarLasComisionesPorVendedor()
        {
            using (var context = new AutosDbContext())
            {
                decimal comision = 0;
                var vendedores = context.Vendedores.ToList();
                foreach (var vendedor in vendedores)
                {
                    System.Console.WriteLine($"\nVendedor:{vendedor.NombreyApellido}" +
                                             $"\nCantidad de Ventas: {vendedor.Ventas.Count}");
                    
                    foreach (var venta in vendedor.Ventas)
                    {
                        System.Console.WriteLine($"\nMarca :{venta.Auto.Marca.NombreMarca}" +
                                                 $"\nModelo: {venta.Auto.Modelo}" +
                                                 $"\nComision:{venta.Comision}\n");
                        
                    }

                    comision = vendedor.Ventas.Sum(v => v.Comision);
                    System.Console.WriteLine($"\nComision Total: {comision}");
                }
            }
        }

        private static void ListarLos3AutosMasCarosFiltradosPorPais()
        {
            using (var context = new AutosDbContext())
            {
                bool repetir = false;
                do
                {
                    System.Console.WriteLine("Ingrese pais del auto :");
                    string pais = System.Console.ReadLine();
                    var autos = context.Autos.ToList().Where(a => a.PaisDeOrigen.NombrePais == pais).OrderByDescending(a=>a.PrecioFinal).Take(3);
                    if (autos.Count() > 0)
                    {
                        foreach (var a in autos)
                        {
                            System.Console.WriteLine($"\nMarca :{a.Marca.NombreMarca}\nModelo: {a.Modelo}\nPrecio:{a.PrecioFinal}\n");
                        }

                        repetir = false;
                    }
                    else
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("Vuelva a ingresar un pais");
                        repetir = true;
                    }
                } while (repetir);
            }
        }

        private static void ListarAutosFiltradosPorMarca()
        {
            using (var context=new AutosDbContext())
            {
                bool repetir = false;
                do
                {
                    System.Console.WriteLine("Ingrese marca del auto :");
                    string marca = System.Console.ReadLine();
                    var autos = context.Autos.ToList().Where(a => a.Marca.NombreMarca == marca);
                    if (autos.Count() > 0)
                    {
                        foreach (var a in autos)
                        {
                            System.Console.WriteLine($"\nMarca :{a.Marca.NombreMarca}\nModelo: {a.Modelo}\nPais:{a.PaisDeOrigen.NombrePais}" +
                                                     $"\nTipo:{a.TipoDeVehiculo.Descripcion}\nPrecio:{a.PrecioFinal}\n");
                        }

                        repetir = false;
                    }
                    else
                    {
                        System.Console.Clear();
                        System.Console.WriteLine("Vuelva a ingresar una marca");
                        repetir = true;
                    } 
                } while (repetir);
            }
        }

        private static void SetSituacionesIdEnClientes()
        {
            using (var context = new AutosDbContext())
            {
                var situacionesIva = context.SituacionesIvas.ToList();
                var clientes = context.Clientes.ToList();
                Random r = new Random();
                foreach (var c in clientes)
                {
                    int posicion = r.Next(situacionesIva.Count());
                    var situacionIva = situacionesIva[posicion];
                    c.SituacionIvaId = situacionIva.SituacionIvaId;
                }

                context.SaveChanges();
                System.Console.WriteLine("Cambios completados!");
            }
        }

        private static void AddSituacionesIva()
        {
            using (var context=new AutosDbContext())
            {
                SituacionIva situacionIva1 = new SituacionIva()
                {
                    Descripcion = "Responsable Inscripto"
                };
                SituacionIva situacionIva2 = new SituacionIva()
                {
                    Descripcion = "Consumidor Final"
                };
                SituacionIva situacionIva3 = new SituacionIva()
                {
                    Descripcion = "Excentos"
                };
                context.SituacionesIvas.AddRange(new List<SituacionIva>(){situacionIva1,situacionIva2,situacionIva3});
                context.SaveChanges();
                System.Console.WriteLine("Situaciones de Iva agregadas");
            }
        }

        //private static void SetLocalidadIdYProvinciaIdEnClientes()
        //{
        //    using (var context=new AutosDbContext())
        //    {
        //        var clientes = context.Clientes.ToList();
        //        foreach (var c in clientes)
        //        {
        //            var loc = c.Localidad;
        //            var localidad = context.Localidades.FirstOrDefault(l => l.Nombre == loc);
        //            c.LocalidadId = localidad.LocalidadId;
        //            c.ProvinciaId = localidad.ProvinciaId;
        //        }

        //        context.SaveChanges();
        //        System.Console.WriteLine("Relaciones actualizadas");
        //    }
        //}

        private static void SetPaisDeOrigenIdEnAutos()
        {
            using (var context = new AutosDbContext())
            {
                var paises = context.PaisesDeOrigen.ToList();
                var autos = context.Autos.ToList();
                Random r = new Random();
                foreach (var a in autos)
                {
                    int posicion = r.Next(paises.Count());
                    var pais = paises[posicion];
                    a.PaisDeOrigenId = pais.PaisDeOrigenId;
                }

                context.SaveChanges();
                System.Console.WriteLine("Cambios completados!");
            }
        }

        private static void SetSucursalIdEnVentas()
        {
            using (var context = new AutosDbContext())
            {
                var sucursales = context.Sucursales.ToList();
                var ventas = context.Ventas.ToList();
                Random r = new Random();
                foreach (var v in ventas)
                {
                    int posicion = r.Next(sucursales.Count());
                    var sucursal = sucursales[posicion];
                    v.SucursalId = sucursal.SucursalId;
                }

                context.SaveChanges();
                System.Console.WriteLine("Cambios completados!");
            }
        }

        private static void AddSucursales()
        {
            using (var context=new AutosDbContext())
            {
                var localidad = context.Localidades.FirstOrDefault(l => l.Nombre == "Lobos");
                Sucursal sucursal1 = new Sucursal()
                {
                    NombreSucursal = "Matias Autos",
                    Calle = "Olavarrieta",
                    Altura = "500",
                    Entre1 = "598",
                    Entre2 = "500",
                    LocalidadId = localidad.LocalidadId,
                    ProvinciaId = localidad.ProvinciaId,
                    CodigoPostal = "7240",
                    TelefonoFijo = "2227 15-47-3946",
                    TelefonoMovil = "411111",
                    CorreoElectronico = "MatiasAutos@gmail.com"
                };
                Sucursal sucursal2 = new Sucursal()
                {
                    NombreSucursal = "Rusconi Automoviles Sa",
                    Calle = "Rivadavia ",
                    Altura = "390",
                    Entre1 = "Calle 1",
                    Entre2 = "Calle 2",
                    LocalidadId = localidad.LocalidadId,
                    ProvinciaId = localidad.ProvinciaId,
                    CodigoPostal = "7240",
                    TelefonoFijo = "2227 42-3958",
                    TelefonoMovil = "4333333",
                    CorreoElectronico = "Rusconi@gmail.com"
                };

                context.Sucursales.AddRange(new List<Sucursal>(){sucursal1,sucursal2});
                context.SaveChanges();
                System.Console.WriteLine("Sucursales agregadas con exito");
            }
        }

        private static void SetCominsionEnVentas()
        {
            using (var context=new AutosDbContext())
            {
                var ventas = context.Ventas.ToList();
                foreach (var v in ventas)
                {
                    var monto = v.Monto;
                    var comision = CalcularComision(monto);
                    v.Comision = comision;
                }

                context.SaveChanges();
                System.Console.WriteLine("Comision añadida");
            }
        }

        private static Decimal CalcularComision(decimal monto)
        {
            var comision = (monto * 3) / 100;
            return comision;
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
                    int posicion = r.Next(autos.Count());
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
