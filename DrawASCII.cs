using System;

class DrawASCII
{ 

    //THE REASON I JUST DIDNT USE A STRING LITERAL, IS BECAUSE YOU CANT PLACE STRING LITERALS WHEREVER YOU WANT IN THE SCREEN ( with "Console.SetCursorPosition(x, y)" , this just doesnt work with literals )
    public static void DrawPaper( int posXSum, int posYSum )
    { 

        Console.ForegroundColor = ConsoleColor.White;

        int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("                 ██      ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("  ████  ████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("  ███████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("  ██████████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" ███████████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 5;
	Console.WriteLine("  ██████████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 6;
	Console.WriteLine("  █████████████████████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 7;
	Console.WriteLine("   ██████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 8;
	Console.WriteLine("  ██████████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 9;
	Console.WriteLine("   ████████████████████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 10;
	Console.WriteLine("  █████████  ███████████ ");

    }



    public static void DrawRock( int posXSum, int posYSum )
    { 

        Console.ForegroundColor = ConsoleColor.DarkGray;

        int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

    
	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("    █████████████████    ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine(" ███████████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("████████████████   ██████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("█████████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("█████████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 5;
	Console.WriteLine("█████████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 6;
	Console.WriteLine("█████████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 7;
	Console.WriteLine("█████████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 8;
	Console.WriteLine("█████████████████████████");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 9;
	Console.WriteLine(" ███████████████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 10;
	Console.WriteLine("    █████████████████    ");


    }

    public static void DrawScissors( int posXSum, int posYSum )
    { 

        Console.ForegroundColor = ConsoleColor.Red;

	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	//DRAWS BLADE OF THE SCISSORS
	Console.ForegroundColor = ConsoleColor.Gray;
	
	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("              ███");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("         ██████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("███████████      ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("   ███████       ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 5;
	Console.WriteLine("         ██████  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 6;
	Console.WriteLine("              ███");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 7;
	Console.WriteLine("");




	//DRAWS THE HANDLE OF THE SCISSORS
	Console.ForegroundColor = ConsoleColor.DarkBlue;
	posX = posX + 17;

	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("█████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("█           ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("█           ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine(" ████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 5;
	Console.WriteLine("█████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 6;
	Console.WriteLine("█           ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 7;
	Console.WriteLine("█████████████ ");



    }

    public static void DrawBracket( int posXSum, int posYSum, string color )
    { 

        if ( color == "white") { Console.ForegroundColor = ConsoleColor.White; }
	if ( color == "darkgray") { Console.ForegroundColor = ConsoleColor.DarkGray; }
	if ( color == "darkblue" ) { Console.ForegroundColor = ConsoleColor.DarkBlue; }

	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("███      ███");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("██        ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("██        ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("██        ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("███      ███");

    }

    private static void DrawVS( int posXSum, int posYSum )
    { 

         Console.ForegroundColor = ConsoleColor.Cyan;

	 int posX = Console.CursorLeft + posXSum;
	 int posY = Console.CursorTop + posYSum;

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY;
	 Console.WriteLine("██              ██     ███ ");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 1;
	 Console.WriteLine(" ██            ██     ██   ");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 2;
	 Console.WriteLine("  ██          ██     ██    ");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 3;
	 Console.WriteLine("   ██        ██     ██     ");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 4;
	 Console.WriteLine("    ██      ██       ██    ");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 5;
	 Console.WriteLine("     ██    ██          ██  ");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 6;
	 Console.WriteLine("      ██  ██             ██");

	 Console.CursorLeft = posX;
	 Console.CursorTop = posY + 7;
	 Console.WriteLine("       ████          █████ ");



    }

    public static void PlayerVSAI( string playerMove, string AIMove )
    { 

         Console.Clear();

         if ( playerMove == "paper" && AIMove == "paper")
	 {
              
              DrawPaper(0, 0); DrawVS(35, 0);  DrawPaper(70, 0);

	 }

	 else if ( playerMove == "paper" && AIMove == "rock")
	 { 

             DrawPaper(0, 0); DrawVS(35, 0); DrawRock(70, 0);
	 
	 }

	 else if ( playerMove == "paper" && AIMove == "scissors")
	 { 
	 
             DrawPaper(0, 0); DrawVS(35, 0); DrawScissors(70, 0);

	 }



	 else if ( playerMove == "rock" && AIMove == "paper")
	 { 

	     DrawRock(0, 0); DrawVS(35, 0); DrawPaper(70, 0);
	 
	 }

	 else if ( playerMove == "rock" && AIMove == "rock")
	 { 

	    DrawRock(0, 0); DrawVS(35, 0); DrawRock(70, 0);
	 
	 }

	 else if ( playerMove == "rock" && AIMove == "scissors")
	 { 

            DrawRock(0, 0); DrawVS(35, 0); DrawScissors(70, 0);
	 
	 }



	 else if ( playerMove == "scissors" && AIMove == "paper")
	 { 

             DrawScissors(0, 0); DrawVS(35, 0); DrawPaper(70, 0);
	 
	 }

	 else if ( playerMove == "scissors" && AIMove == "rock" )
	 { 

            DrawScissors(0, 0); DrawVS(35, 0); DrawRock(70, 0);
	 
	 }

	 else if ( playerMove == "scissors" && AIMove == "scissors")
	 { 

            DrawScissors(0, 0); DrawVS(35, 0); DrawScissors(70, 0);
	 
	 }
    }
	    
}
