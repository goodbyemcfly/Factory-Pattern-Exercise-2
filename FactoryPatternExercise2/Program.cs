namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What type of database would you like to use? Please select from the following options:");
            Console.WriteLine("'List' 'SQL' 'Mongo'");

            var userInput = Console.ReadLine();

            IDataAccess dataSet = DataAccessFactory.GetAccessType(userInput);

            dataSet.LoadData();
            dataSet.SaveData();
        }
    }
}
