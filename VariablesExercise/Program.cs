namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            string myComputer = "CLX";
            int myStorage = 500;
            bool storageFull = true;
            char numberComputers = '2';
            double myTemp = 123.4567;
            decimal myBandwidth = 97.5m;
            string userInput;
           

            Console.WriteLine($"My computer's brand name is {myComputer}.");
            Console.WriteLine($"The storage on my {myComputer} is {myStorage} GigaBytes. ");
            Console.WriteLine($"If you were to ask me if my storage was full I would have to say {storageFull}.");
            Console.WriteLine($"The amount of computers I own is {numberComputers} with an average Tempature of {myTemp} degrees Farenheit.");
            Console.WriteLine($"My internet speed is not as quick as I would like. It is only {myBandwidth} mbps fast. ");





        }
    }
}
