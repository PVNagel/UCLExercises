namespace Tusindfryd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "OurName";
            string image = "0110101";
            int productionTimeinDays = 15;
            int decayTime = 30;
            int size = 5;

            Controller control = new Controller();
            BlomsterSortRepo repo = new BlomsterSortRepo();
            BlomsterSort flower = new BlomsterSort(name, image, productionTimeinDays, decayTime, size);

            control.Add(flower);

            Console.WriteLine(flower.ToString());
            Console.ReadLine();



        }
    }
}