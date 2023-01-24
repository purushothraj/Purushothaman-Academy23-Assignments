using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharacterRepInDict{
   internal class Program{
      static void Main(string[] args){
         Dictionary<char, int> dict = new Dictionary<char, int>();
         var charcount = Tuple.Create('A', 0);
         string[] Words = File.ReadAllLines("D:\\OneDrive - Trumpf Metamation Pvt Ltd\\Desktop\\words\\words.txt");
         foreach (string word in Words){
            for(int i =0; i < word.Length;i++){
               if (dict.TryGetValue(word[i],out int value))
               {
                  dict[word[i]] = ++value;
               }else dict[word[i]] =1;
            }
         }int k = 0;
         foreach (KeyValuePair<char, int> pair in dict.OrderByDescending(key => key.Value)){
            if (k < 7){
               Console.WriteLine(pair.Key + " : " + pair.Value);
               k++;
            }
         }  
      }
   }
}