using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    static class Extentions
    {
        public static bool CustomContains(this string sentence, string newsentence)
        {
            bool search = false;
            int index = 0;
            sentence = sentence.ToLower();
            newsentence = newsentence.ToLower();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (newsentence.Length == 1)
                {
                    char temp = newsentence[0];
                    if (sentence[i] == temp)
                    {
                        search = true;
                    }


                    else
                    {

                        if (sentence[i] == newsentence[0] && sentence[i + 1] == newsentence[1])
                        {
                            search = true;

                            index = i;

                        }
                        for (int j = 2; j < newsentence.Length; j++)
                        {
                            if (sentence[index + 2] == newsentence[j])
                            {

                                index++;
                                search = true;
                                
                                

                                
                            }
                        }  

                    }
                }
                else
                {
                    continue;
                }
                return search;
            }
        }    
        
    }
}
















