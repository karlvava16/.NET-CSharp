using System;

static void PlayQuiz(Quiz quiz)
{
    Random random = new Random();
    int score = 0;

    foreach (Question question in quiz.Questions.OrderBy(q => random.Next()))
    {
        Console.WriteLine(question.Text);
        int i = 1;
        foreach (string option in question.Options)
        {
            Console.WriteLine($"{i}. {option}");
            i++;
        }
        Console.Write("Enter your answer: ");
        int answer = int.Parse(Console.ReadLine());
        if (question.Options[answer - 1] == question.Answer)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine($"Wrong! The correct answer is {question.Answer}");
        }
    }

    Console.WriteLine($"Your score is {score} out of {quiz.Questions.Count}");
}
