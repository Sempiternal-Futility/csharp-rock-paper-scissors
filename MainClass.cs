using System;

class MainClass : ExtraMethods
{ 

    static void Main()
    { 

         Console.Clear();
	 Console.CursorVisible = false;
	 Console.Title = "Paper-Rock-Scissors";

         PickYourMove();
	 CompareAItoPlayer();
	 AskPlayAgain();

    }

    private static void AskPlayAgain()
    { 

        Console.WriteLine("DO YOU WANT TO PLAY AGAIN? (Y/n)");
	bool loopSwitch = true;

        while ( loopSwitch )
	{ 

	   switch( Console.ReadKey(true).KeyChar )
	   { 
                case 'y' :
	             loopSwitch = false; Main();
                     break;

		case 'n' :
		     loopSwitch = false; Console.WriteLine("BYE! :)");
		     break;

		default :
		       loopSwitch = true;
		       break;

	   }

	}


    }
}
