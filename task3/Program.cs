namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            car BMW=new car();
            BMW.make = "BMW";
            BMW.model = "E36";
            BMW.Year = 1999;
            BMW.melage = 1000;
            BMW.displayCarInfo();
            Console.WriteLine($"car distains = { BMW.drive(9000)}");
           BMW.clacaluteCarAge();

        }
    }

    public class car
    {

        public string make { get; set; }
        public string model { get; set; }
        public int Year { get; set; }
        public int melage {  get; set; }

        public int drive(int distains)
        {
            return melage + distains;
        }

        public void clacaluteCarAge()
        {
            int currentAge=DateTime.Now.Year;// thinks chatGPT for this info
            int carAge =currentAge-Year ;

            Console.WriteLine($"car age={carAge}"); 
        }
        public void displayCarInfo()
        {
            Console.WriteLine($"car made by\n= {make}\nmodel\n= {model}\nyear\n= {Year} ");
        }
    }
    


}
