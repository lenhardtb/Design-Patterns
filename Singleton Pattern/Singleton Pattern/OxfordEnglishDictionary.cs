using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Singleton_Pattern
{
    public class OxfordEnglishDictionary
    {
        //the underlying dictionary
        //key is the entry, value is what would be returned by getDefinition(key)
        Dictionary<String, Dictionary<String, ICollection<String>>> underlying;

        //the filename for the file the dictionary reads from
        private static readonly String fileName = "Singleton_Pattern.dictionary.txt";
        private static String[] wordTypes = new String[] { "noun.", "adj.", "verb.", "adv.", "abbr.", "symb.", "n.", "v."};

        private readonly Object synchronizer = new Object();

        private static OxfordEnglishDictionary instance;
        
        private OxfordEnglishDictionary()
        {
            //connects to file
            //tries to get a serialized collection of already searched words for speed improvement, if it can't no big deal.
            try
            {
                Stream stream = File.OpenRead("usedEntries.dat");
                BinaryFormatter formatter = new BinaryFormatter();
                underlying = (Dictionary<String, Dictionary<String, ICollection<String>>>)formatter.Deserialize(stream);
            }
            catch
            {
                underlying = new Dictionary<String, Dictionary<String, ICollection<String>>>();
            }
        }

        /// <summary>
        /// Gets the instance of the dictionary.
        /// </summary>
        /// <returns>the instance of the dictionary.</returns>
        public static OxfordEnglishDictionary getDictionary()
        {
            if (instance == null)
            {
                instance = new OxfordEnglishDictionary();
            }
            
            return instance;
        }

        /// <summary>
        /// Returns a Dictionary of type String, ICollection(of type String).
        /// (The return type being called Dictionary does not mean that it represents this dictionary, that's just the name of the key-value based collection in the C# collections interface)
        /// 
        /// The keys of this dictionary corresponds to the word type of the definition(s) - e.g. noun, verb, etc.
        /// The value represents a collection of the definitions for that type.
        /// A word may have three different definitions when used as a noun and two when used as an adjective, for example.
        /// 
        /// If the word is not found, this will return an empty dictionary.
        /// </summary>
        /// <param name="word">A word to find the definition of. NOTE: the dictionary this is based off of includes some multiple-word phrases.</param>
        public Dictionary<String, ICollection<String>> getDefinition(String word)
        {
            if(underlying.ContainsKey(word))
            {
                return underlying[word];
            }

            lock (synchronizer)
            {
                Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(fileName);

                
                StreamReader reader = new StreamReader(new BufferedStream(stream));

                //this loop iterates once for each line
                while (!reader.EndOfStream)
                {
                    String wholeLine = reader.ReadLine();
                    StringReader line = new StringReader(wholeLine);
                    //read entry - some entries are multiple words, but all are separated from defs by two spaces
                    String entry = "";

                    do
                    {
                        entry += line.Next();
                    }
                    while (!(line.Peek() == ' ' || line.Peek() == -1));

                    line.Read();//second space indicating end of word

                    //word found
                    if (entry.Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Dictionary<String, ICollection<String>> returner = new Dictionary<String, ICollection<String>>();
                        
                        String aWord = line.Next();

                        //the outer boolean expression should check for end of string, 
                        //but the empty string would not pass the isWordType test anyway

                        //this loop iterates once for each word type present
                        while (isWordType(aWord))
                        {
                            ICollection<String> subEntries = new LinkedList<String>();
                            returner.Add(aWord, subEntries);
                            
                            String subEntry = "";
                            int throwaway = 0;//it's gotta do a TryParse later but the actual number is irrelevant
                            aWord = line.Next();
                            //this loop iterates once for each word until end of line

                            while (!aWord.Equals(""))
                            {
                                subEntry += aWord + " ";

                                aWord = line.Next();
                                
                                if(isWordType(aWord))
                                {
                                    break;
                                }
                                //new subentry - these are led by an index
                                if (int.TryParse(aWord, out throwaway))
                                {
                                    subEntries.Add(subEntry);
                                    //reset subEntry
                                    subEntry = "";
                                }//if(new def)
                            }//while(not end)
                        }//while(each word type)
                        
                        //word may have an additional usage note on line below it
                        line = new StringReader(reader.ReadLine());

                        if (line.Next().StartsWith("Usage"))
                        {
                            ICollection<String> usageNote = new List<String>(1);
                            usageNote.Add(line.ReadToEnd());

                            returner.Add("Usage:", usageNote);
                        }

                        underlying.Add(word, returner);

                        return returner;
                    }//if word found
                }//while lines left

                
                reader.Close();
            }//synchronization lock

            //definition not found
            Dictionary<String, ICollection<String>> returnerEmpty = new Dictionary<String, ICollection<String>>();
            underlying.Add(word, returnerEmpty);//it helps to register things that are NOT words too I guess
            return returnerEmpty;
        }//getDefinition

        private static bool isWordType(String word)
        {
            for (int i = 0; i < wordTypes.Length; i++)
                if (word.Equals(wordTypes[i], StringComparison.CurrentCultureIgnoreCase))
                    return true;
            for (int i = 0; i < wordTypes.Length; i++)
                if (word.Equals("—" + wordTypes[i], StringComparison.CurrentCultureIgnoreCase))
                    return true;
            for (int i = 0; i < wordTypes.Length; i++)
                if (word.Equals("-" + wordTypes[i], StringComparison.CurrentCultureIgnoreCase))
                    return true;
            
            return false;
        }
    }//class(OxfordEnglishDictionary)
    
    public static class MyUtils
    {
        //I REALLY missed this feature of the Scanner(String) class in java
        public static String Next(this StringReader s)
        {
            StringBuilder returner = new StringBuilder();
            char c = 'x';
            while (s.Peek() != -1)
            {
                c = (char)s.Read();
                if (c == ' ') break;
                returner.Append(c);
            }
            return returner.ToString();
        }
    }
}//namespace
