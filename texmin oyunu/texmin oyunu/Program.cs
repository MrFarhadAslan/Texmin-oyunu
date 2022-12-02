namespace texmin_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts = new TimeSpan(0, 0, 1);
            
            Random rnd = new Random();
            bool result;
            int random_number= rnd.Next(0,20);
            int estimate_fee = 3;
            int estimate;
            while (true)
            {

                Console.WriteLine("Texmininizi yazin");
                string eded=Console.ReadLine();
                

                result = Int32.TryParse(eded, out estimate);

                if (result)
                {
                    if (estimate > random_number)
                    {
                        estimate_fee--;
                        Console.WriteLine("Loading...");
                        Thread.Sleep(ts);
                        Console.WriteLine("Daha kicik eded daxil edin!");
                    }
                    else if (estimate < random_number)
                    {
                        estimate_fee--;
                        Console.WriteLine("Loading...");
                        Thread.Sleep(ts);
                        Console.WriteLine("Daha boyuk eded daxil edin!");
                    }
                    else
                    {
                        Console.WriteLine("Loading...");
                        Thread.Sleep(ts);
                        Console.WriteLine("Congratulations");
                        break;
                    }
                }
                if (estimate_fee==0)
                {
                    Console.WriteLine("Texmin haqqiniz bittdi!");
                    Console.WriteLine("Texmin elemili oldugunuz eded "+random_number);
                    break;  
                }
            }
        }
    }
}