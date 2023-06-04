
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
            CorrectChoice = 2
        },
        new Question
        {
            Text = "What is the tallest mountain in the world?",
            Choices = new string[] { "St. Helens", "Everest", "Mt Fuji", "Machu Pichu" },
            CorrectChoice = 1
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
            CorrectChoice = 2
        },
    };
    public void StartQuiz()
    {
        Console.WriteLine("Welcome to Aden Ennis' Quiz game!!!");
        Console.WriteLine("There are six questions good luck!");

        score = 0;
        currentquestion = 0;

        while (currentquestion < questions.Length)
        {
            AskQuestion();
        }

        Console.WriteLine($"Game Over! Your score is: {score}/{questions.Length}");

    }

    private void AskQuestion()
    {
        Question currentQuestion = questions[currentquestion];

        Console.WriteLine($"Question {currentquestion + 1}: {currentQuestion.Text}");
        for (int i = 0; i < currentQuestion.Choices.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {currentQuestion.Choices[i]}");
        }

        Console.Write("Choose your answer (1-4): ");
        string user_choice = Console.ReadLine();
        if (int.TryParse(user_choice, out int choice))
        {
            if (choice >= 1 && choice <= 4)
            {
                CheckAnswer(choice - 1);
                currentquestion++;
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again uing (1-4)");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice! You must use a number");
        }

        Console.WriteLine("");
    }

    private void CheckAnswer(int choice)
    {
        Question currentQuestion = questions[currentquestion];
        if (currentQuestion.Correct(choice) == true)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }
    }
}

