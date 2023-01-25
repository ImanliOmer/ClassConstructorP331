namespace ClassConstructorP331
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal Qarga = new Animal();
            //Qarga.Name = "Qarga";
            //Qarga.Breed = "Erkey";
            //Qarga.Color = "Black";
            //Qarga.Age = 3;
            //Console.WriteLine(Qarga.GetDetails());


            //Animal Dovsan = new Animal();
            //Dovsan.Name = "Dovsan";
            //Dovsan.Breed = "Erkey";
            //Dovsan.Color = "Gray";
            //Dovsan.Age = 2;
            //Console.WriteLine(Dovsan.GetDetails());

            //Animal Deve = new Animal();
            //Deve.Name = "Deve";
            //Deve.Breed = "Erkey";
            //Deve.Color = "Qehveyi";
            //Deve.Age = 3;
            //Console.WriteLine(Qarga.GetDetails());
            /////////////////////////////////////////////////////////////////////////////////////////////////
            Building Eyfel = new Building("Eyfel",900,200);          
            Eyfel.adress = "Fransa Paris";
            Console.WriteLine(Eyfel.GetInfo());
            Console.WriteLine(Eyfel.GetHeight());

        }

    }
}