using System.IO;
using System.Runtime.Serialization.Json;


namespace ConsoleDictionary
{
    abstract class BilingualDictionaryJson
    {
        public static bool Save(string filename, BilingualDictionary bd)
        {
            if (bd.GetAmount() != 0)
            {
                FileStream stream = null;
                DataContractJsonSerializer jsonFormatter = null;
                stream = new FileStream(filename, FileMode.Create);
                jsonFormatter = new DataContractJsonSerializer(typeof(BilingualDictionary));
                jsonFormatter.WriteObject(stream, bd);
                stream.Close();

                return true;
            }
            return false;
        }

        public static bool Load(string filename, ref BilingualDictionary bd)
        {
            FileStream stream = null;
            DataContractJsonSerializer jsonFormatter = null;

            stream = new FileStream(filename, FileMode.Open);
            jsonFormatter = new DataContractJsonSerializer(typeof(BilingualDictionary));
            bd = (BilingualDictionary)jsonFormatter.ReadObject(stream);
            stream.Close();

            return true;
        }
    }
}
