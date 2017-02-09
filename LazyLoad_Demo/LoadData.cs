using System;

namespace LazyLoad_Demo
{
    public class LoadData
    {
       public static void Main(string[] args)
        {

            LoadDataAlmacen();

        }

        static void LoadDataAlmacen()
        {
            var Empresas_AlmacenesEntities = new AlmacenEntities();

            //Instanciamos solo la entidad Empresa
            var Empresas = Empresas_AlmacenesEntities.Empresa.Include("Almacen");  

            foreach (var empresa in Empresas)
            {

                Console.WriteLine("La empresa obtenida es : {0} y su fecha de creación es {1}", empresa.nombre, empresa.fecha.ToString());

                //Listamos sus almacenes por cada empresa

                foreach (var almacen in empresa.Almacen)
                {
                    Console.WriteLine("El almacen para la empresa seleccionada  es : {0} y su fecha de creación es {1}", almacen.nombre, almacen.fecha.ToString());
                }

                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }

        }   


    }
}
