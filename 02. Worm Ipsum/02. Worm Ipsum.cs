using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
   public class Program
    {
       public static void Main()
        {
            var sentence = Console.ReadLine();
            var count = 0;
            var changeChar = string.Empty;
            while (sentence!= "Worm Ipsum")
            {

                var countResult = new Dictionary<char, long>();
                var wordResult = new HashSet<string>();
                var totalResult = new Dictionary<HashSet<string>, Dictionary<char, long>>();


                var regex = new Regex(@"^[A-Z].*[.]$");
                var isValid = regex.IsMatch(sentence);
                if (isValid)
                {
                    var dotSplit = sentence.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries); //are they more than 1 sentence on 1 line - yes: readline, no - algorithm;
                    if (dotSplit.Length == 1)
                    {
                        foreach (var sentenceSplittedByDot in dotSplit) //Split one line sentences by dot so they became like 1 per line;
                        {

                            var sentenceParts = sentenceSplittedByDot
                                .Split(new[] { '.', ' ' }
                                , StringSplitOptions.RemoveEmptyEntries);
                            foreach (var word in sentenceParts)
                            {
                                count = 0;
                                for (int i = 0; i < word.Length; i++)
                                {
                                    var previousLetter = word[i];
                                    for (int j = i+1; j < word.Length; j++)
                                    {
                                        var nextLetter = word[j];

                                        if (previousLetter == nextLetter)
                                        {
                                            wordResult.Add(word);
                                            if (countResult.ContainsKey(previousLetter))
                                            {
                                                countResult[previousLetter]++;
                                            }
                                            else
                                            {
                                                countResult[previousLetter] = ++count ;
                                            }
                                        }
                                    }
                                }
                            }
                            totalResult.Add(wordResult, countResult);
                            foreach (var character in totalResult)
                            {
                                var maxOccurances = string.Empty;
                                var orderByToGetFirst = character.Value.OrderByDescending(x => x.Value);
                                foreach (var item in character.Value)
                                {
                                    maxOccurances = item.Key.ToString();
                                    break;
                                }
                                foreach (var word in totalResult.Keys)
                                {
                                    for (int i = 0; i < word.Count; i++)
                                    {
                                        var wordToChar = word;
                                        foreach (var item in wordToChar)
                                        {
                                            changeChar = sentence.Replace(wordToChar, maxOccurances[0]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine(changeChar + ".");
                }
                sentence = Console.ReadLine();
            }
        }
    }
}