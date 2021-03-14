using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FileClass
    {
        public static Dictionary<String, int> ReadFile(String file)
        {
            Dictionary<String, int> dictionary = new Dictionary<String, int>();
            try {
                StreamReader reader = new StreamReader(file);
                StringBuilder buf = new StringBuilder();
                foreach (char c in reader.ReadToEnd()) {
                    if (ParseClass.parsing(c.ToString()))
                    {
                        buf.Append(c);
                    }
                    else if (ParseClass.parsing(buf.ToString()))
                    {
                        int count = 0;
                        if (dictionary.TryGetValue(buf.ToString(), out count)) {
                            count++;
                        } else {
                            count = 1;
                        }
                        dictionary[buf.ToString()] = count;
                        buf = new StringBuilder("");
                    }
                }
                if (buf.Length > 0 && ParseClass.parsing(buf.ToString()))
                {
                    int count = 0;
                    if (dictionary.TryGetValue(buf.ToString(), out count))
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    dictionary[buf.ToString()] = count;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            return dictionary;
        }

        public static void WriteFile(List<KeyValuePair<String, int>> dictionary, String file)
        {
            try{
                StreamWriter writer = new StreamWriter(file, false);
                foreach (KeyValuePair<String, int> value in dictionary)
                {
                    writer.WriteLine(value.Key + " : " + value.Value );
                }
                writer.Close();
            } 
            catch (IOException exception)
            {
                Console.WriteLine(exception);
            }
        }

    }
}
