namespace L9_EBEAM_1200922
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil objAutomovil = new Automovil(2019, 10000.00, "", false, 7.50, 0.00);

            Console.WriteLine(" Ingrese la marca del automovil ");
           
            objAutomovil.DefinirMarca(Console.ReadLine());

            Console.WriteLine(" Ingrese el modelo : ");

            objAutomovil.DefinirModelo(int.Parse(Console.ReadLine()));


            Console.WriteLine(" Ingrese Su disponibilidad : (Disponible o No Disponible) ");

            if (Console.ReadLine() == "Disponible")
            {
                objAutomovil.DefinirDisponible();
            }


            Console.WriteLine(" Ingrese el precio : ");

            objAutomovil.DefinirPrecio(double.Parse(Console.ReadLine()));

            Console.WriteLine(" Ingrese el tipo de cambio de dolar : ");

            objAutomovil.DefinirTipoCambioDolar(double.Parse(Console.ReadLine()));

            Console.WriteLine(" Ingrese el descuento  : ");

            objAutomovil.DefinirDescuentoAplicado(double.Parse(Console.ReadLine()));

            Console.WriteLine(objAutomovil.MostrarInformacion());

            Console.ReadKey();
        }
    }

    class Automovil
    {
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;

        public Automovil(int Modelo, double Precio, string Marca, bool Disponible, double TipoCambioDolar, double DescuentoAplicado)
        {
            modelo = Modelo;
            precio = Precio;
            marca = Marca;
            disponible = Disponible;
            tipoCambioDolar = TipoCambioDolar;
            descuentoAplicado = DescuentoAplicado;
        }

        public void DefinirModelo(int unModelo)
        {
            modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }

        public void DefinirMarca(string unMarca)
        {
            marca = unMarca;
        }

        public void DefinirDisponible()
        {
            if (disponible == true)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }

        public void DefinirTipoCambioDolar(double unTipoCambioDolar)
        {
            tipoCambioDolar = unTipoCambioDolar;
        }
        public void DefinirDescuentoAplicado(double unDescuentoAplicado)
        {
            descuentoAplicado = unDescuentoAplicado;
        }

        public string MostrarDisponibilidad()
        {
            if (disponible == true)
            { 
                return ": Disponible ";
            }
            else
            {
                return ": No disponible ";
            }
        }
       
        public string MostrarInformacion()
        {
            return " Marca: " + marca + ", Precio: " + precio + " , Modelo : " + modelo + " , Disponible : " + MostrarDisponibilidad() + " , Tipo de Cambio " +tipoCambioDolar +  " , El Descuento es : " + descuentoAplicado + " , El Precio en dolares : "+ (precio / 7.50)  + ", Precio con descuento :  " + (precio - descuentoAplicado);
        }

    }
}