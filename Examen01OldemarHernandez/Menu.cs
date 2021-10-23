using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01OldemarHernandez
{
    class Menu
    {

        static int opcion;

        static Pagos pagos = new Pagos();


        public Menu()
        {
            opcion = 0;


        }
        public Menu(int op)
        {
            opcion = op;
        }
        public static void principal()
        {
            do
            {
                Console.WriteLine("***** MENU PRINCIPAL ******");
                Console.WriteLine("1-Inicializar Arreglos");
                Console.WriteLine("2-Realizar Pago");
                Console.WriteLine("3-Consultar Pago");
                Console.WriteLine("4-Modificar Pago");
                Console.WriteLine("5-Elimina Pago");
                Console.WriteLine("6-Sub Menu");
                Console.WriteLine("7-Salir");
                Console.WriteLine("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    case 1:pagos.InicializarArreglos();

                        break;
                    case 2:pagos.AgregarPago();


                        break;
                    case 3:pagos.ConsultarPago();
                       
                        break;
                    case 4:pagos.modificarPago();
                        
                        break;
                    case 5:pagos.eliminarPago();
                        
                        break;
                    case 6:
                        do
                        {
                            Console.WriteLine("*****SUD MENU REPORTES ******");
                            Console.WriteLine("1-VER PAGOS");
                            Console.WriteLine("2-VER PAGOS POR SERVICIOS");
                            Console.WriteLine("3-VER PAGOS POR CODIGO DE CAJA");
                            Console.WriteLine("4-VER COMISION POR PAGOS");
                            Console.WriteLine("5-REGRESAR AL MENU");
                            Console.WriteLine("Ingrese una opcion: ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:pagos.reportePago();
                                        break;
                                case 2:
                                    pagos.ReporteTipoServicio();
                                    break;
                                case 3:
                                    pagos.ReporteTipoCodigoCaja();
                                    break;


                                default:
                                    break;
                            }

                        } while (opcion != 5);
                        break;
                }
            } while (opcion != 7);
        }
    }

}