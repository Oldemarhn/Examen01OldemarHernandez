using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen01OldemarHernandez
{
    class Pagos
    {
        int[] numeropago = new int[10];
        DateTime[] fecha = new DateTime[10];
        String[] hora = new string[10];
        String[] cedula = new string[10];
        String[] nombre = new string[10];
        String[] apellidos = new string[10];
        int[] numerocaja = new int[10];
        String[] tiposervicio = new string[10];
        int[] numerofactura = new int[10];
        String[] montopagar = new string[10];
        String[] comision = new string[10];
        String[] montodeducido = new string[10];
        String[] montototal = new string[10];
        String[] vuelto = new string[10];
        int pos;
        int contador = 0;
        int factura = 1001;
        Random rnd = new Random();


        public Pagos()
        {
            pos = 0;
        }


        public void InicializarArreglos()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                numeropago[i] = 0;
                cedula[i] = "";
                nombre[i] = "";
                apellidos[i] = "";
                numerocaja[i] = 0;
                tiposervicio[i] = "";
                numerofactura[i] =0;
                montopagar[i] = "";
                comision[i] = "";
                montodeducido[i] = "";
                montototal[i] = "";
                vuelto[i] = "";


            }
        }


        public void AgregarPago()
        {

            char opcion = 's';
            do
            {
                if (contador<10)
                {
                    numeropago[contador] = contador+1;
                    fecha[contador] = DateTime.Today;
                    hora[contador] = DateTime.Now.ToString();
                    Console.WriteLine("Digite la cedula");
                    cedula[pos] = Console.ReadLine();
                    Console.WriteLine("Digite Nmbre");
                    nombre[pos] = Console.ReadLine();
                    Console.WriteLine("Digite los apellidos");
                    apellidos[pos] = Console.ReadLine();
                    numerocaja[pos] = rnd.Next(1, 3);
                    Console.WriteLine("Digite tipo servicio 1.Luz,2.Telefono;3.Agua");
                    tiposervicio[pos] = Console.ReadLine();
                    //factuara = 1000 + 1;
                    numerofactura[contador]=factura;
                    factura  ++;
                    Console.WriteLine("Digite monto a pagar");
                    int montopagar1= Int32.Parse(Console.ReadLine());
                    montopagar[pos] = montopagar1.ToString();
                    Console.WriteLine("Digite comision");
                    comision[pos] = Console.ReadLine();
                    Console.WriteLine("Digite deuccion");
                    montodeducido[pos] = Console.ReadLine();
                    Console.WriteLine("Digite total");
                    int montototal1 = Int32.Parse(Console.ReadLine());
                    montototal[pos] = montototal1.ToString();
                    //Console.WriteLine("Digite vuelto");
                    int vuelto1 = montototal1 - montopagar1;
                    vuelto[pos] = vuelto1.ToString();
                    pos++;
                    contador++;
                    Console.WriteLine("Desea agregar otro Pago s/n");
                    opcion = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    opcion = 'n';
                }

            } while (opcion != 'n');
        }

        public void ConsultarPago()// pendiente modificar para pagos
        {
            Console.WriteLine("Ingrese el numero de pago:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < numeropago.Length; i++)
            {
                if (ced.Equals(numeropago[i].ToString()))
                {
                    Console.WriteLine($"El numero de pago es: {numeropago[i]}");
                    Console.WriteLine($"La Fecha es: {fecha[i]}");
                    Console.WriteLine($"La Hora es: {hora[i]}");
                    Console.WriteLine($"La Cedula es: {cedula[i]}");
                    Console.WriteLine($"El Nombre es: {nombre[i]}");
                    Console.WriteLine($"Los Apellidos: {apellidos[i]}");
                    Console.WriteLine($"El Numero de caja es: {numerocaja[i]}");
                    Console.WriteLine($"El Tipo de Servicio es: {tiposervicio[i]}");
                    Console.WriteLine($"El numero de factura es: {numerofactura[i]}");
                    Console.WriteLine($"El monto a pagar es: {montopagar[i]}");
                    Console.WriteLine($"El monto deducido es: {montodeducido[i]}");
                    Console.WriteLine($"El monto total es: {montototal[i]}");
                    Console.WriteLine($"El vuelto es: {vuelto[i]}");

                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El pago no existe");
            }
        }
        public void eliminarPago()
        {
            Console.WriteLine("Ingrese el numero de pago:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < numeropago.Length; i++)
            {
                if (ced.Equals(numeropago[i].ToString()))
                {
                    numeropago[i] = 0;
                    cedula[i] = "";
                    nombre[i] = "";
                    apellidos[i] = "";
                    numerocaja[i] = 0;
                    tiposervicio[i] = "";
                    numerofactura[i] = 0;
                    montopagar[i] = "";
                    comision[i] = "";
                    montodeducido[i] = "";
                    montototal[i] = "";
                    vuelto[i] = "";

                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El pago no existe");
            }
        }


        public void modificarPago()
        {
            Console.WriteLine("Ingrese el numero de pago:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < numeropago.Length; i++)
            {
                if (ced.Equals(numeropago[i].ToString()))
                {
                    //numeropago[contador] = contador + 1;
                    fecha[i] = DateTime.Today;
                    hora[i] = DateTime.Now.ToString();
                    Console.WriteLine("Digite la cedula");
                    cedula[i] = Console.ReadLine();
                    Console.WriteLine("Digite Nombre");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digite los apellidos");
                    apellidos[i] = Console.ReadLine();
                    numerocaja[i] = rnd.Next(1, 3);
                    Console.WriteLine("Digite tipo servicio 1.Luz,2.Telefono;3.Agua");
                    tiposervicio[i] = Console.ReadLine();
                    //factuara = 1000 + 1;
                    Console.WriteLine("Digite El numero de factura");
                    numerofactura[i] = factura;
                    factura++;
                    Console.WriteLine("Digite monto a pagar");
                    montopagar[i] = Console.ReadLine();
                    Console.WriteLine("Digite comision");
                    comision[i] = Console.ReadLine();
                    Console.WriteLine("Digite deuccion");
                    montodeducido[i] = Console.ReadLine();
                    Console.WriteLine("Digite total");
                    montototal[i] = Console.ReadLine();
                    Console.WriteLine("Digite vuelto");
                    vuelto[i] = Console.ReadLine();

                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El pago no existe");
            }
        }

        public void reportePago()
        {
            for (int i = 0; i < numeropago.Length; i++)
            {

                    Console.WriteLine($"El numero de pago es: {numeropago[i]}");
                    Console.WriteLine($"La Fecha es: {fecha[i]}");
                    Console.WriteLine($"La Hora es: {hora[i]}");
                    Console.WriteLine($"La Cedula es: {cedula[i]}");
                    Console.WriteLine($"El Nombre es: {nombre[i]}");
                    Console.WriteLine($"Los Apellidos: {apellidos[i]}");
                    Console.WriteLine($"El Numero de caja es: {numerocaja[i]}");
                    Console.WriteLine($"El Tipo de Servicio es: {tiposervicio[i]}");
                    Console.WriteLine($"El numero de factura es: {numerofactura[i]}");
                    Console.WriteLine($"El monto a pagar es: {montopagar[i]}");
                    Console.WriteLine($"El monto deducido es: {montodeducido[i]}");
                    Console.WriteLine($"El monto total es: {montototal[i]}");
                    Console.WriteLine($"El vuelto es: {vuelto[i]}");
                    Console.WriteLine($"  ");
                    Console.WriteLine($" Los datos del: {numeropago[i]}");

            }
        }
       public void ReporteTipoServicio()
        {
            Console.WriteLine("Ingrese el tipo de servicio:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < tiposervicio.Length; i++)
            {
                if (ced.Equals(tiposervicio[i].ToString()))
                {
                    Console.WriteLine($"El tipo de servicio {tiposervicio[i]}"+" son");
                    Console.WriteLine($"El numero de pago es: {numeropago[i]}");
                    Console.WriteLine($"La Fecha es: {fecha[i]}");
                    Console.WriteLine($"La Hora es: {hora[i]}");
                    Console.WriteLine($"La Cedula es: {cedula[i]}");
                    Console.WriteLine($"El Nombre es: {nombre[i]}");
                    Console.WriteLine($"Los Apellidos: {apellidos[i]}");
                    Console.WriteLine($"El Numero de caja es: {numerocaja[i]}");
                    Console.WriteLine($"El Tipo de Servicio es: {tiposervicio[i]}");
                    Console.WriteLine($"El numero de factura es: {numerofactura[i]}");
                    Console.WriteLine($"El monto a pagar es: {montopagar[i]}");
                    Console.WriteLine($"El monto deducido es: {montodeducido[i]}");
                    Console.WriteLine($"El monto total es: {montototal[i]}");
                    Console.WriteLine($"El vuelto es: {vuelto[i]}");
                    Console.WriteLine($"  ");

                    // existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El pago no existe");
            }
        }

        public void ReporteTipoCodigoCaja()
        {
            Console.WriteLine("Ingrese el Numero de Caja:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < numerocaja.Length; i++)
            {
                if (ced.Equals(numerocaja[i].ToString()))
                {
                    Console.WriteLine($"El NUmero de caja {numerocaja[i]}" + " son");
                    Console.WriteLine($"El numero de pago es: {numeropago[i]}");
                    Console.WriteLine($"La Fecha es: {fecha[i]}");
                    Console.WriteLine($"La Hora es: {hora[i]}");
                    Console.WriteLine($"La Cedula es: {cedula[i]}");
                    Console.WriteLine($"El Nombre es: {nombre[i]}");
                    Console.WriteLine($"Los Apellidos: {apellidos[i]}");
                    Console.WriteLine($"El Numero de caja es: {numerocaja[i]}");
                    Console.WriteLine($"El Tipo de Servicio es: {tiposervicio[i]}");
                    Console.WriteLine($"El numero de factura es: {numerofactura[i]}");
                    Console.WriteLine($"El monto a pagar es: {montopagar[i]}");
                    Console.WriteLine($"El monto deducido es: {montodeducido[i]}");
                    Console.WriteLine($"El monto total es: {montototal[i]}");
                    Console.WriteLine($"El vuelto es: {vuelto[i]}");
                    Console.WriteLine($"  ");

                    // existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El pago no existe");
            }
        }

    }

}
 
