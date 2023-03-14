using System;

class DrawASCII
{ 

    //THE REASON I JUST DIDNT USE A STRING LITERAL, IS BECAUSE YOU CANT PLACE STRING LITERALS WHEREVER YOU WANT IN THE SCREEN ( with "Console.SetCursorPosition(x, y)" , this just doesnt work with literals )
    public static void DrawPaper( int posXSum, int posYSum )
    { 

        Console.ForegroundColor = ConsoleColor.Yellow;

        int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;


	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("                 ██      ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("  ████  █████████  █████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("  ██  ██               ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("  ██                  ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine(" ██                   ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 5;
	Console.WriteLine("  ██                  ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 6;
	Console.WriteLine("  ██                 ██  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 7;
	Console.WriteLine("   ██                  ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 8;
	Console.WriteLine("  ██                  ██ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 9;
	Console.WriteLine("   ██     ██          █  ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 10;
	Console.WriteLine("  ████████  ███████████  ");

    }



    public static void DrawRock( int posXSum, int posYSum )
    { 

        Console.ForegroundColor = ConsoleColor.Gray;

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

        Console.ForegroundColor = ConsoleColor.DarkBlue;         

	int posX = Console.CursorLeft + posXSum;
	int posY = Console.CursorTop + posYSum;

	Console.CursorLeft = posX;
	Console.CursorTop = posY;
	Console.WriteLine("                 █████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 1;
	Console.WriteLine("              ████           ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 2;
	Console.WriteLine("         ██████  █           ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 3;
	Console.WriteLine("███████████       ████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 4;
	Console.WriteLine("   ███████                     ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 5;
	Console.WriteLine("         ██████  █████████████ ");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 6;
	Console.WriteLine("              ████           ██");

	Console.CursorLeft = posX;
	Console.CursorTop = posY + 7;
	Console.WriteLine("                 █████████████ ");


    }
	    
}
