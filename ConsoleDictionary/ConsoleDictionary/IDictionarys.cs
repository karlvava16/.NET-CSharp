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
        string Word(string word);                                           // слово
    }
}
