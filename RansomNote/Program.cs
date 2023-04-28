using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CanConstruct("aab", "baa"));
            //Console.WriteLine(CanConstruct("fffbfg", "effjfggbffjdgbjjhhdegh"));
            //Console.WriteLine(CanConstruct("a", "b"));
            Console.WriteLine(CanConstruct("aa", "ab"));
            Console.WriteLine(CanConstruct("aa", "aab"));
            //Console.WriteLine(CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));
        }


        public static bool CanConstruct(string ransomNote, string magazine)
        {
            List<char> bob = new List<char>(ransomNote.ToCharArray());
            List<char> zod = new List<char>(magazine.ToCharArray());
            List<char> meg = new List<char>(ransomNote.ToCharArray());

            //bob.Add(ransomNote);
            //string[] strings = ransomNote.Split(' ');

            //foreach(string s in strings)
            //{
            //    Console.WriteLine(s + "\n ");
            //}

            for (int i = 0; i < bob.Count; i++)
            {
                int j = i;
                for (j = 0; j < zod.Count; j++)
                {
                    if (bob[i] == zod[j])
                    {
                        //Console.WriteLine((char)i);
                        meg.Remove(bob[i]);
                        //break;
                    }
                }
            }

            //foreach(char c in meg) {
            //    Console.WriteLine("here\t" + c);
            //    Console.WriteLine("there\t" + meg.Count);
            //}



            if (meg.Count == 0)
            //if (magazine.Contains(ransomNote))
            {
                Debug.WriteLine("bob");
                return true;

            }
            else
                return false;
        }
    }
}
