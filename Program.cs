// See https://aka.ms/new-console-template for more information

using game1401_la_5;
Random random = new Random();
LearningActivity5_1();
LearningActivity5_2();
return;

int randomInt()
{
    return random.Next(1, 1000000);
}
void LearningActivity5_1()
{
    List<HighScores> highScores = new List<HighScores>();
    GameSelection choice;

    do
    {
        choice = ChooseOption();

        switch(choice)
        {
            case GameSelection.Play:
                int scores = randomInt();
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
    List<Videos> videos = new List<Videos>();

    //c Template for me to add videos to this
    videos.Add(new Videos("Borderline Forever", randomInt(), "Blue boarder almost ends humanity", 1.06));
    videos.Add(new Videos("The Dark Age of Nintendo", randomInt(), "The dark age of nintendo", 1.76));
    videos.Add(new Videos("The Childhood game Collecton", randomInt(),"Scott the Woz talks about spongebob for 2 hours", 2.29));
    videos.Add(new Videos("It came from the Nintendo eShop", randomInt(), "Wagabagabobo", 1.83));
    videos.Add(new Videos("The Great Mysteries of Gaming", randomInt(), "The jailor has decided to execute you", 0.3));
    videos.Add(new Videos("Game Shaw Games", randomInt(), "Comedy", 0.21));
    videos.Add(new Videos("Game Baths", randomInt(), "Imagine a Lenny face here I couldn't get it to work", 0.05));
    videos.Add(new Videos("Game Packaging", randomInt(), 
        "Have you ever wanted to watch a man talk about video game packaging for an hour, if so this video is for you", 0.75));
    
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
