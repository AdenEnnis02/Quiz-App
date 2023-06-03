using System;

public class Question
{
    public string Text { get; set; }
    public string[] Choices { get; set; }
    public int CorrectChoice { get; set; }

    public bool Correct(int choice)
    {
        return choice == CorrectChoice;
    }
}

public class QuizGame
{
    private int currentquestion;
    private int score;
    private static Question[] questions = new Question[]
    {
        new Question
        {
            Text = "Where are Kangaroos Located?",
            Choices = new string[] { "Australlia", "Asia", "Europe", "South America" },
            CorrectChoice = 0
        },
        new Question
        {
            Text = "What is the biggest animal on the planet?",
            Choices = new string[] { "Elephant", "Beluga Whale", "Blue Whale", "Giraffe" },
            CorrectChoice = 1
        },
        new Question
        {
            Text = "What is the tallest mountain in the world?",
            Choices = new string[] { "St. Helens", "Everest", "Mt Fuji", "Machu Pichu" },
            CorrectChoice = 0
        },
        new Question
        {
            Text = "What Country has the highest population?",
            Choices = new string[] {"India", "USA", "Indonesia", "China"},
            CorrectChoice = 3
        },
        new Question
        {
            Text = "Which is the largest state in the USA?",
            Choices = new string[] {"California", "Alaska", "Texas", "North Carolina"},
            CorrectChoice = 1
        },
        new Question
        {
            Text = "What is the fastest land animal on the Earth?",
            Choices = new string[] { "Lion", "Prong Horn", "Cheetas", "Leopard"},
            CorrectChoice = 0
        },
    };
}