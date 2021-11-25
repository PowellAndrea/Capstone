// Andrea Powell
// IT113
// NOTES:


using System;

namespace StringMaker_Powell
{
    class Program
    {        
        static void Main(string[] args)
        {
            StringManager myThing = new StringManager();

            Console.WriteLine( "Reverse Sunbeam Tiger: " + myThing.Reverse("Sunbeam Tiger")) ;

            //Console.WriteLine( "ToString('Dan'): " + myThing.ToString("Dan"));
            Console.WriteLine( "ToString('One Two Five Three'):" + myThing.ToString("One Two Five Three") );

            Console.WriteLine( "Reverse Sunbeam Tiger with case: " + myThing.Reverse("Sunbeam Tiger", true) );

            Console.WriteLine( "Equals('Sunbeam Tiger'): " + ( myThing.Equals("Sunbeam Tiger")) );

            Console.WriteLine( "is ABBA symmetric?  " + myThing.Symetrics("ABBA") );
            Console.WriteLine( "is ABA symmetric?   " + myThing.Symetrics("ABA") );
            Console.WriteLine( "is ABba symmetric?  " + myThing.Symetrics("ABba") );
        }
    }
}
