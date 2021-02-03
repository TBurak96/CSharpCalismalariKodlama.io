using System;
using System.Collections.Generic;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Daha evvelden aynı isimli çalışmam olduğu için isimlendirmeyi bu şekilde yaptım.

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1919, "Kurtuluş Savaşı başladı.");
            dictionary.Add(1920, "Türkiye Büyük Millet Meclisi kuruldu.");
            dictionary.Add(1923, "Cumhuriyet ilan edildi.");

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
            
            dictionary.Remove(1919);

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
          

            dictionary.Clear();

            Console.ReadLine();
        }
    }
}
