using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//WordList Class
//This is where all of the parse JSON data from Jisho is stored.

namespace JSON_Parsing
{
    class WordList
    { 
        public class Meta
        {
            public int status { get; set; }
        }

        public class Japanese
        {
            public string reading { get; set; }
            public string word { get; set; }
        }

        public class Sens
        {
            public List<string> english_definitions { get; set; }
            public List<string> parts_of_speech { get; set; }
            public List<object> links { get; set; }
            public List<object> restrictions { get; set; }
            public List<object> see_also { get; set; }
            public List<object> antonyms { get; set; }
            public List<object> source { get; set; }
            public List<string> info { get; set; }
            public List<object> sentences { get; set; }
            public List<string> tags { get; set; }

            public string combinedInfo { get; set; }
            public void setCombinedInfo()
            {
                Console.WriteLine(info.Count);
                for (int i = 0; i < info.Count; i++)
                {
                    if (i != tags.Count - 1)
                        combinedInfo += info[i] + ", ";
                    else
                        combinedInfo += info[i];
                }
            }

            public string combinedTags { get; set; }
            public void setCombinedTags()
            {
                for (int i = 0; i < tags.Count; i++)
                {
                    if (i != tags.Count - 1)
                        combinedTags += tags[i] + ", ";
                    else
                        combinedTags += tags[i];
                }
            }

            public string combinedPartsOfSpeech { get; set; }
            public void setCombinedPOS()
            {
                for (int i = 0; i < parts_of_speech.Count; i++)
                {
                    if (i != parts_of_speech.Count - 1)
                        combinedPartsOfSpeech += parts_of_speech[i] + ", ";
                    else
                        combinedPartsOfSpeech += parts_of_speech[i];
                }
            }
        }

        public class Attribution
        {
            public bool jmdict { get; set; }
            public bool jmnedict { get; set; }
            public object dbpedia { get; set; }
        }

        public class Datum
        {
            public bool is_common { get; set; }
            public List<string> tags { get; set; }
            public List<Japanese> japanese { get; set; }
            public List<Sens> senses { get; set; }
            public Attribution attribution { get; set; }
            public string display { get { return japanese[0].word; } }
            public string combinedTags { get; set; }
            public void setCombinedTags()
            {
                for (int i = 0; i < tags.Count; i++)
                {
                    if (i != tags.Count - 1)
                        combinedTags += tags[i] + ", ";
                    else
                        combinedTags += tags[i];
                }
            }
        }

        public class RootObject
        {
            public Meta meta { get; set; }
            public List<Datum> data { get; set; }
        }
    }
}
