// See https://aka.ms/new-console-template for more information

using game1401_la_5;
Random random = new Random();
LearningActivity5_1();
LearningActivity5_2();
return;

int inputInt (string stringInput)//Make the user input a number between 1 and 3
{
    bool notValid = true;
    int input = 0;
    do
    {
        Console.WriteLine(stringInput);
        if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 3)
        {
            notValid = true;
        }
    }while (notValid);

    return input;
}

int randomInt()//Returns a random number between 1 and 1,000,000
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

User createNewUser(List<Videos> videos)
{
    Console.WriteLine("What is the User's name?");
    User newUser = new User(Console.ReadLine(),randomInt());

    for (int i = 0; i < videos.Count;i++)//Automatically adding random videos into the new user
    {
        if (random.Next(0, 3) == 2)
        {
            newUser.addCurrentVideo(videos[i]);
        }

        if (random.Next(0, 3) == 2)
        {
            newUser.addPreviousVideo(videos[i]);
        }

    }
    Console.WriteLine("User "+newUser.getName+" ID: " + newUser.getId()+" created!");
    return newUser;
}
void LearningActivity5_2()
{
    List<Videos> videos = new List<Videos>();
    List<User> users = new List<User>();

    videos.Add(new Videos("Borderline Forever", randomInt(), "Blue boarder almost ends humanity", 1.06));
    videos.Add(new Videos("The Dark Age of Nintendo", randomInt(), "The dark age of nintendo", 1.76));
    videos.Add(new Videos("The Childhood game Collecton", randomInt(),"Scott the Woz talks about spongebob for 2 hours", 2.29));
    videos.Add(new Videos("It came from the Nintendo eShop", randomInt(), "Wagabagabobo", 1.83));
    videos.Add(new Videos("The Great Mysteries of Gaming", randomInt(), "The jailor has decided to execute you", 0.3));
    videos.Add(new Videos("Game Shaw Games", randomInt(), "Comedy", 0.21));
    videos.Add(new Videos("Game Baths", randomInt(), "Imagine a Lenny face here I couldn't get it to work", 0.05));
    videos.Add(new Videos("Game Packaging", randomInt(), 
        "Have you ever wanted to watch a man talk about video game packaging for an hour, if so this video is for you", 0.75));

    bool stillLooping = true;
    int input = 0;
    do
    {
        switch (inputInt("Do you wanna\n1: Get the videos\n2: Go into the user menu\n3: Exit"))
        {
            case 1:
                for (int i = 0; i < videos.Count; i++)
                {
                    Console.WriteLine((i + 1) + ": ");
                    videos[i].printVideo();
                }
                break;
        }
    } while (stillLooping);

}
GameSelection ChooseOption()
{
    int selection = inputInt("Would you like to:\n\t 1: Play again\n\t 2: See the list of high scores\n\t 3: Exit the game?");
    return (GameSelection)selection;

}
//Be kind, rewind.


enum GameSelection
{
    Play = 1, SeeHighScore = 2, Exit = 3
}
