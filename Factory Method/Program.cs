using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    // Product
    public abstract class Envio
    {
        public abstract decimal CalcularCosto();
        public abstract int CalcularTiempoEntrega();
    }

    // Concrete Products
    public class EnvioAereo : Envio
    {
        public override decimal CalcularCosto()
        {
            return 100;
        }

        public override int CalcularTiempoEntrega()
        {
            return 2;
        }
    }

    public class EnvioTerrestre : Envio
    {
        public override decimal CalcularCosto()
        {
            return 50;
        }

        public override int CalcularTiempoEntrega()
        {
            return 5;
        }
    }

    public class EnvioMaritimo : Envio
    {
        public override decimal CalcularCosto()
        {
            return 80;
        }

        public override int CalcularTiempoEntrega()
        {
            return 10;
        }
    }

    // Creator
    public abstract class CreadorEnvio
    {
        public abstract Envio CrearEnvio();
    }

    // Concrete Creators
    public class CreadorEnvioAereo : CreadorEnvio
    {
        public override Envio CrearEnvio()
        {
            return new EnvioAereo();
        }
    }

    public class CreadorEnvioTerrestre : CreadorEnvio
    {
        public override Envio CrearEnvio()
        {
            return new EnvioTerrestre();
        }
    }

    public class CreadorEnvioMaritimo : CreadorEnvio
    {
        public override Envio CrearEnvio()
        {
            return new EnvioMaritimo();
        }
    }

    // Cliente
    class Program
    {
        static void Main(string[] args)
        {
            CreadorEnvio creador = new CreadorEnvioAereo();
            Envio envio = creador.CrearEnvio();
            Console.WriteLine("Costo del envío: $" + envio.CalcularCosto());
            Console.WriteLine("Tiempo de entrega: " + envio.CalcularTiempoEntrega() + " días");
            Console.ReadLine();
        }
    }


}
