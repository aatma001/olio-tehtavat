using System;

namespace T_20_Nisäkäs
{
    class Program
    {
        static void Main(string[] args)
        {

            Ihminen ihminen = new Ihminen(60, "Kalevi", 120, 150);
            Console.WriteLine(ihminen.ToString());

            Aikuinen ihminen1 = new Aikuinen(24, "Juho", 70, 178, "Toyota");
            Console.WriteLine(ihminen1.ToString());

            Vauva vauva = new Vauva(1, "Jonne", 6, 100, "Libero");
            Console.WriteLine(vauva.ToString());

            vauva.Kasva();
            ihminen.Kasva();

            Console.WriteLine(vauva.ToString());





        }
    }
}
