using System;

namespace OOP1
{
   class Empleados
    {
       private string Nombre;
       private float Cedula;
       private int Edad;
       private float Salario;
        private string Departamento;

        //Funciones de dichos atributos
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public float cedula
        {
            get { return Cedula; }
            set { Cedula = value; }
        }

        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public float salario
        {
            get { return Salario; }
            set {

                if (value <= 0) {
                    Console.WriteLine("El salario ingresado no es valido. ");
                    Salario = value; 
                    
                }
            
            
            }
        }

        public string departamento
        {
            get { return Departamento; }
            set { Departamento = value; }
        }

        class Almacen : Empleados
        {
            private int recepcion;
            private int envioMer;
            private string CoCalidad;
            private int Inventario;

            public int Recepcion
            {
                get { return recepcion; }
                set { recepcion = value; }
            }

            public int EnvioMer {

                get { return envioMer; }
                set { recepcion = value; }
            }

            private string coCalidad
            {
                get { return CoCalidad;  }
                set { coCalidad = value; }

            }

            public int inventario
            {
                get { return Inventario; }
                set { Inventario = value; }
            }

            class InicioAlmacen
            {
                static void Main(string[] args) {

                    Almacen e = new Almacen(); //instancia
                    Console.WriteLine("Indique el nombre del empleado: "); e.Nombre = Console.ReadLine();
                    Console.WriteLine("Indique su numero de Cedula del empleado: "); e.Cedula = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique la edad del empleado: "); e.Edad = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique el salario del empleado: "); e.Salario = System.Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Indique a que departamente pertenece: "); e.Departamento = Console.ReadLine();

                    Console.WriteLine("Indique cuantos productos se recibieron: "); e.Recepcion = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique Cuantos productos se enviaron: ");  e.EnvioMer = System.Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indique Calidad final de los productos: Escelente, buena, media, mala. "); e.CoCalidad = (Console.ReadLine());
                    Console.WriteLine("Indique el inventario: "); e.Inventario = System.Convert.ToInt32(Console.ReadLine());



                    //salidas

                    Console.WriteLine("Resultados: ");
                    Console.WriteLine("Nombre: {0}", e.Nombre);
                    Console.WriteLine("Cedula: {0}", e.Cedula);
                    Console.WriteLine("Edad: {0}", e.Edad);
                    Console.WriteLine("Salario: {0}", e.Salario);
                    Console.WriteLine("Departamento: {0}", e.Departamento);

                    Console.WriteLine("Productos Recibidos: {0}", e.Recepcion);
                    Console.WriteLine("Productos Enviados: {0}", e.EnvioMer);
                    Console.WriteLine("Calidad Final: {0}", e.CoCalidad);
                    Console.WriteLine("Inventario final: {0}", e.Inventario);


                } 

            }
        }


    }
   
}
