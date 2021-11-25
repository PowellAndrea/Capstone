// Andrea Powell
// IT113
// NOTES: 
//  I am my own worst enemy, thank you for the reminders to not go with
//  the first solution or get distracted by the wrong problem.

using System;
using System.Collections;
using System.Collections.Generic;

namespace StringMaker_Powell
{
    public class StringManager
    {
        private string lastInput = "";
        public string Reverse(string s)
        {
            this.lastInput = s;
            string myString ="";

            Stack<char> myStack = new Stack<char>();

            foreach(char c in s){
                myStack.Push(c);
            }

            while (myStack.Count > 0){
                myString += myStack.Pop();
            }
            return (myString);
        }

        public string Reverse(string s, bool saveCase)
        {
            this.lastInput = s;

            if (saveCase != true){ return Reverse(s);}

            Stack<int>  myIndex = new Stack<int>();
            Stack<char> myChars = new Stack<char>();

            foreach(char c in s){
                if (char.IsUpper(c) == true) {
                 myIndex.Push(s.IndexOf(c));
                }
            }

            char[] myArray = (Reverse(s)).ToLower().ToCharArray();

            while(myIndex.Count > 0){
                myArray[myIndex.Peek()] = char.ToUpper(myArray[myIndex.Pop()]);
            }
            return (string.Join("", myArray));
        } 

        public bool Symetrics(string s)
        {
            this.lastInput = s;

            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            CharEnumerator chNum = s.GetEnumerator();
            chNum.MoveNext();

            for (int x = 1; x <= (s.Length/2); x++){
                stack1.Push(chNum.Current);
                chNum.MoveNext();
            }

            // if length string is not even; skip the middle letter
            if (s.Length % 2 == 0 ) { stack2.Push(chNum.Current); }
             else { chNum.MoveNext(); stack2.Push(chNum.Current); }

            while (chNum.MoveNext()){
                stack2.Push(chNum.Current);
            }

            if ( stack1.Count != stack2.Count ) { return false;}

            while (stack1.Count > 0 || stack2.Count > 0){
                if ( stack1.Pop() != stack2.Pop() ){ return false; }
            }
            return true;
        }

        public string ToString(string s)
        {   
            lastInput = s;
            string strReturn = "";

            string[] _words = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
            int myInt = 0;

            foreach (char c in s){
                myInt = myInt + Convert.ToInt32(c);
            }  

            if (myInt <= 0) {return("Negative One");}

            while (myInt > 0){
                strReturn = ( _words[(myInt % 10)] + " " + strReturn );
                myInt = myInt / 10;
            }
            return (strReturn);

            // Math from here - hooray for math!
            // https://dotnettutorials.net/lesson/count-number-of-digits-in-an-integer-number-csharp/
        }

        public override bool Equals(object obj)
        {
         if ((obj is string) && (obj.ToString() == this.lastInput))
         { return true;  }
            else { return false; }
        }
    }
}