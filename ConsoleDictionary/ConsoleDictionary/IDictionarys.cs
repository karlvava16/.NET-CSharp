using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDictionary
{
    public interface IDictionaries  // требования к словарю
    {
        bool AddWord(string word, params string[] translation);             // добавить слово с переводом
        bool AddTranslation(string word, params string[] translation);      // добавить перевод
        bool ContainsWord(string word);                                     // сущесвтуе ли слово в словаре
        bool RemoveWord(params string[] word);                              // удалить слово
        bool RemoveTranslation(string word, params string[] translation);   // удалить перевод
        string[] GetTranslation(string word);                               // получить перевод слов
    }
}
