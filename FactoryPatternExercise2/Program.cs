namespace FactoryPatternExercise2
{
    internal class Program

    {
        static void Main(string[] args)
        {
            string UserInput ;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("What Data Base would you like to use?");
                Console.WriteLine("Type sql.");
                Console.WriteLine("Type mongo");
                Console.WriteLine("Type list");


                UserInput = Console.ReadLine();

                if( UserInput != "sql" || UserInput != "mongo" || UserInput != "list")
                {
                    correctInput = false;
                    Console.WriteLine("Bad Input!");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);

            Console.Clear();
            IDataAccess db = DataAccessFactory.DatabaseAcessType(UserInput);

            var products = db.LoadData();
            db.SaveData();
             
            foreach(var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}  ");

            }
            
        }
    }
}