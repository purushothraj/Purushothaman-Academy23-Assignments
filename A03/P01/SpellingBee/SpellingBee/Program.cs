using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.ExceptionServices;
using System.Linq;
using System.IO.IsolatedStorage;

namespace SpellingBee{
   internal class Program{
      static void Main(string[] args){
         Dictionary<char, List<string>> FullDict = BuildDictionary("D:\\OneDrive - Trumpf Metamation Pvt Ltd\\Desktop\\words\\words.txt");
         char[] letters = new[] { 'U', 'X', 'A', 'T', 'L', 'N', 'E' };
         List<string> Validlist = BuildValidList(letters, FullDict);
         Dictionary<char,List<string>> quicklist= new Dictionary<char,List<string>>();
         


      }

      static Dictionary<char, List<string>> BuildDictionary(string path)
      {
         Dictionary<char, List<string>> dict = new Dictionary<char, List<string>>();
         string[] Words = File.ReadAllLines(path);
         List<string> words = new List<string>();
         int totalWords = Words.Length;
         char Lastchar = 'A';
         int j = 0,length;
         for (int i = 0; i < 26; i++){
            words = new List<string>();
            maxlength[i] = 0;
            for(; j < totalWords;){
               if (Words[j][0].Equals(Lastchar)){
                  length = Words[j].Length;
                  if (maxlength[i] < length) maxlength[i]= length;
                  if (length>3) words.Add(Words[j]);
                  j++;
               }else{
                  dict.Add(Lastchar,words);
                  Lastchar = Words[j][0];
                  break;
               }
            }
         }dict.Add(Lastchar, words);
         return dict;
      }
      static List<string> BuildValidList(char[] letters, Dictionary<char, List<string>> FullDict){
         List<string> Validlist = new List<string>();
         foreach (char c in letters)
         {
            List<string> Templist = new List<string>();
            foreach (string s in FullDict[c])
            {
               if (s.Contains(letters[0])) Templist.Add(s);
            }
            bool valid = true;
            foreach (string s1 in Templist)
            {
               for (int i = 0; i < s1.Length; i++)
               {
                  if (!letters.Contains(s1[i]))
                  {
                     valid = false;
                     break;
                  }
               }
               if(valid) Validlist.Add(s1);
            }
         }
         return Validlist;
      }
      static int[] maxlength = new int[26];
   }
}