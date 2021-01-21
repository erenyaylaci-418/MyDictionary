using System;

namespace GecenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> myList = new MyList<string>();
            myList.Add("Eren");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
