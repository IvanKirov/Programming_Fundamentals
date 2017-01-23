using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            long timeAllPictures = numberPictures * (long)filterTime;
            double filterPictures = Math.Ceiling(numberPictures / 100.0 * filterFactor);
            long totalTime = (long)(filterPictures * uploadTime + timeAllPictures);
                        
            long days = totalTime / (3600 * 24);
            long hours = totalTime / 3600 - (days * 24);
            long minutes = totalTime / 60 - ((days * 24 + hours) * 60);
            long seconds = totalTime - ((days * 24 + hours) * 60 + minutes) * 60;
            Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{seconds:00}");

            // as above less code
            TimeSpan t = TimeSpan.FromSeconds(totalTime);            
            Console.WriteLine($"{t.Days}:{t.Hours:00}:{t.Minutes:00}:{t.Seconds:00}");
        }
    }
}
