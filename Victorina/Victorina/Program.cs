using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace QuizApp
{
    public class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }
    }

    public class Quiz
    {
        private List<Question> questions;

        public Quiz()
        {
            questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            questions.Add(question);
        }

        public void RemoveQuestion(Question question)
        {
            questions.Remove(question);
        }

        public void Save(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new StreamWriter(fileName))
            {
                serializer.Serialize(stream, questions);
            }
        }

        public static Quiz Load(string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new StreamReader(fileName))
            {
                var questions = (List<Question>)serializer.Deserialize(stream);
                var quiz = new Quiz();
                quiz.questions.AddRange(questions);
                return quiz;
            }
        }

        public void Play()
        {
            var random = new Random();
            var score = 0;
            foreach (var question in questions.OrderBy(q => random.Next()))
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i]}");
                }
                Console.Write("Your answer: ");
                var answer = Console.ReadLine();
                if (answer == question.CorrectAnswer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {question.CorrectAnswer}.");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Your score is {score} out of {questions.Count}.");
        }
    }

    public class Program
    {
        private Quiz quiz;

        public Program()
        {
            quiz = new Quiz();
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Quiz App");
                Console.WriteLine("1
