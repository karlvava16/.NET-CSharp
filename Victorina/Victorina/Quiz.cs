using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

class Quiz
{
    private List<Question> questions = new List<Question>();

    public void AddQuestion(Question question)
    {
        questions.Add(question);
    }

    public void RemoveQuestion(Question question)
    {
        questions.Remove(question);
    }

    public void SaveQuestions(string filename)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
        using (TextWriter writer = new StreamWriter(filename))
        {
            serializer.Serialize(writer, questions);
        }
    }

    public void LoadQuestions(string filename)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
        using (TextReader reader = new StreamReader(filename))
        {
            questions = (List<Question>)serializer.Deserialize(reader);
        }
    }
}
