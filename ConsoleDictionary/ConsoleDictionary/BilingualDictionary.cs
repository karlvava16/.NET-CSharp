using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleDictionary
{

    // класс словаря
    [DataContract]
    public class BilingualDictionary : IDictionaries
    {
        // тип словаря
        [DataMember]
        private string dictType;
        public string DictType { get { return dictType; } }

        // бинарное дерево ключей(слов) и значений(массив переводов)
        [DataMember]
        private SortedDictionary<string, List<string>> dict;

        public SortedDictionary<string, List<string>> Dict { get { return dict; } }

        // получить кол-во слов в словаре
        public int GetAmount()
        {
            return Dict.Count;
        }

        public string[] this[string value]
        {
           get { return Dict[value].ToArray(); }
        }


        // конструктор по умолчанию
        public BilingualDictionary(string dictTpye)
        {
            dict = new SortedDictionary<string, List<string>>();
            dictType = dictTpye;
        }

        // добавление слов (анг, русс)
        public bool AddWord(string word, params string[] translation)
        {
            if (Dict.ContainsKey(word))
            {
                return false;
            }
            else
            {
                Dict.Add(word, new List<string>(translation));
                return true;
            }
        }

        // существует ли слово уже в словаре
        public bool ContainsWord(string word)
        {
            return Dict.ContainsKey(word);
        }

        // получить перевод слова
        public string[] GetTranslation(string word)
        {
            List<string> translation;
            bool success = Dict.TryGetValue(word, out translation);
            if (success)
            {
                return translation.ToArray();
            }
            else
            {
                return null;
            }
        }

        // добавить перевод к слову
        public bool AddTranslation(string word, params string[] translation)
        {
            if (Dict.ContainsKey(word))
            {
                var length = translation.Length;
                foreach (var item in translation)
                {
                    if (!Dict[word].Contains(item))
                        Dict[word].Add(item);
                }
                return length != translation.Length;
            }
            else
            {
                return false;
            }
        }

        // удалить перевод
        public bool RemoveTranslation(string word, params string[] translation)
        {
            if (Dict.ContainsKey(word))
            {
                var length = translation.Length;
                foreach (var item in translation)
                {
                    if (!Dict[word].Contains(item) && Dict[word].Count > 1)
                        Dict[word].Remove(item);
                }
                return length != translation.Length;
            }
            else
            {
                return false;
            }
        }

        // удалить слово
        public bool RemoveWord(params string[] words)
        {
            var length = words.Length;
            foreach (var word in words)
            {
                if (Dict.ContainsKey(word))
                {
                    Dict.Remove(word);
                }
            }
            return length != words.Length;
        }

        // слово
        public string Word(string word)
        {
            if (Dict.ContainsKey(word))
            {
                StringBuilder temp = new StringBuilder();
                temp.Append(word + " —");
                foreach (var item in Dict[word])
                {
                    temp.Append(" " + item + ",");
                }
                temp[temp.Length - 1] = '.';
                return temp.ToString();
            }
            return null;
        }
    }
}
