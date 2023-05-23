using System;


        Main();
        static void Main()
        {
            MainFunction();
            void MainFunction(){
            Console.WriteLine(@"Welcome to the Enthusiastic Moose Simulator!
            --------------------------------------------");
            Console.WriteLine();
            // Let the moose speak!
            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic");

            // As a question
           
            // Console.WriteLine(isTrue);
            //Gabby's Way to call questions
            // CanadaQuestion();
            // EnthusiasticQuestion();
            // LoveCSharpQuestion();
            // SecretQuestion();

//Nic's Way
            AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I KNEW IT !!!");
            AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
            AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
            AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
            }
        

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

//Gabby's Way
void AskQuestion(string question, string yesResponse, string noResponse) // we're passing in 3 strings, question, yesResponse, and noResponse
{
    bool isTrue = MooseAsks(question); //if the answer is yes, isTrue will be true, if the answer is no, isTrue will be false
    // if (isTrue)
    // {
    //     MooseSays(yesResponse);
    // }
    // else
    // {
    //     MooseSays(noResponse);
    // }

    string response = isTrue ? yesResponse : noResponse ;

    MooseSays(response);
}

//Gabby's Way to call questions
// void CanadaQuestion()
// {
//     AskQuestion("Is Canada real?", "Really? It seems very unlikely.", "I KNEW IT !!!");
// }

// void EnthusiasticQuestion()
// {
//     AskQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
// }

// void LoveCSharpQuestion() 
// { 
//     AskQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
// }

// void SecretQuestion() {
//     AskQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
// }


//Kara's Way
// void AllOfTheQuestions(){
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }
// }
// AllOfTheQuestions();


bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
// void EnthusiasticQuestion()


// void LoveCSharpQuestion()


// void SecretQuestion()

        
        }