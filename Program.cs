// See https://aka.ms/new-console-template for more information

using game1401_la_5;

LearningActivity5_1();
LearningActivity5_2();
return;

void LearningActivity5_1()
{
    List<HighScores> highScores = new List<HighScores>();
    GameSelection choice;
    Random randomScore = new Random();

    do
    {
        choice = ChooseOption();

        switch(choice)
        {
            case GameSelection.Play:
                int scores = randomScore.Next(1000, 1000000);
                Console.WriteLine("Your score is "+scores+"\nPlease enter your name:\n");
                string name = Console.ReadLine();
                highScores.Add(new HighScores(scores, name));
                break;
            case GameSelection.SeeHighScore:
                if (highScores.Count < 1)
                {
                    Console.WriteLine("There are no recorded high scores");
                }
                else
                {
                    for (int i = 0; i < highScores.Count; ++i)
                    {
                        highScores[i].printHighScore();
                    }
                }
                break;
            case GameSelection.Exit:
                Console.WriteLine("Ok, bye bye!");
                break;
        }

    } while (choice != GameSelection.Exit);
}
void LearningActivity5_2()
{
    Random randomId = new Random();
}
GameSelection ChooseOption()
{
    bool validSelection = false;
    int selection = 0;
    while (!validSelection)
    {
        Console.WriteLine(
            "Would you like to:\n\t 1: Play again\n\t 2: See the list of high scores\n\t 3: Exit the game?");

        if (int.TryParse(Console.ReadLine(), out selection) && selection >= 1 && selection <= 3)
            validSelection = true;

    }

    return (GameSelection)selection;

}
//Be kind, rewind.


enum GameSelection
{
    Play = 1, SeeHighScore = 2, Exit = 3
}
