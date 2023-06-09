using System;

class ExtraMethods
{ 

    //0 = PAPER, 1 = ROCK, 2 = SCISSORS
    static byte playerMove;


    public static void PickYourMove()
    { 

        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"
██████  ██  ██████ ██   ██     ██    ██  ██████  ██    ██ ██████      ███    ███  ██████  ██    ██ ███████          
██   ██ ██ ██      ██  ██       ██  ██  ██    ██ ██    ██ ██   ██     ████  ████ ██    ██ ██    ██ ██               
██████  ██ ██      █████         ████   ██    ██ ██    ██ ██████      ██ ████ ██ ██    ██ ██    ██ █████            
██      ██ ██      ██  ██         ██    ██    ██ ██    ██ ██   ██     ██  ██  ██ ██    ██  ██  ██  ██               
██      ██  ██████ ██   ██        ██     ██████   ██████  ██   ██     ██      ██  ██████    ████   ███████ ██ ██ ██			


			");



	DrawASCII.DrawPaper(0, 0);
	DrawASCII.DrawRock(50, -11);
	DrawASCII.DrawScissors(94, -10);

	DrawASCII.DrawBracket(7, 4, "white");
	DrawASCII.DrawBracket(57, -5, "darkgray");
	DrawASCII.DrawBracket(108, -5, "darkblue");

	//DRAWS THE MARKER IN THE FIRST PAIR OF BRACKETS
	DrawMarker(12, 24);

	MarkerLogic();

    }

      
    //THIS "MARKER" IS THE LITTLE CYAN SQUARE THAT YOU USE TO CHOOSE
    private static void MarkerLogic()
    { 

      while ( 1 > 0 )
      {

	//THE " + 2" IS HERE BECAUSE THE MARKER STRING IS 2 CHARS LONG, SO THIS EVEN THINGS OUT
	(int Left, int Top) paperPos = (12 + 2, 24);
	(int Left, int Top) rockPos = (62 + 2, 24);
	(int Left, int Top) scissorsPos = (113 + 2, 24);

        var readInput = Console.ReadKey(true).Key;
	(int Left, int Top) currentPos = Console.GetCursorPosition();

 
        //CONFIRMATION "IFs"
	if ( readInput == ConsoleKey.Enter && currentPos == paperPos )
	{ playerMove = 0; break; }
	
	if ( readInput == ConsoleKey.Enter && currentPos == rockPos )
	{ playerMove = 1; break; }

	if ( readInput == ConsoleKey.Enter && currentPos == scissorsPos )
	{ playerMove = 2; break; }

   

	//MOVEMENTS "IFs"
	if ( readInput == ConsoleKey.D && currentPos == paperPos )
	{ EraseMarker(12, 24); DrawMarker(62, 24); }

  

	if ( readInput == ConsoleKey.D && currentPos == rockPos )
	{ EraseMarker(62, 24); DrawMarker(113, 24); }

	if ( readInput == ConsoleKey.A && currentPos == rockPos )
	{ EraseMarker(62, 24); DrawMarker(12, 24); }



	if ( readInput == ConsoleKey.A && currentPos == scissorsPos )
	{ EraseMarker(113, 24); DrawMarker(62, 24); }

      }


    }

    private static void EraseMarker( int posX, int posY )
    { 

         Console.SetCursorPosition(posX, posY);
	 Console.ForegroundColor = ConsoleColor.Black;
	 Console.Write("██");

    }

    private static void DrawMarker( int posX, int posY )
    { 

         Console.SetCursorPosition(posX, posY);
	 Console.ForegroundColor = ConsoleColor.Cyan;
	 Console.Write("██");
   
    }




    public static void CompareAItoPlayer()
    { 

        byte aiMove = (byte)new Random().Next(0, 3);



        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

	if ( aiMove == 0 )
	{ 
	
	     if ( playerMove == 0 )
	     { DrawASCII.PlayerVSAI("paper", "paper"); }

	     else if ( playerMove == 1 )
	     { DrawASCII.PlayerVSAI("rock", "paper"); }

	     else if ( playerMove == 2 )
	     { DrawASCII.PlayerVSAI("scissors", "paper"); }

	
	}

	if ( aiMove == 1 ) 
	{ 
	        
             if ( playerMove == 0 )
	     { DrawASCII.PlayerVSAI("paper", "rock"); }

	     if ( playerMove == 1 )
	     { DrawASCII.PlayerVSAI("rock", "rock"); }

	     if ( playerMove == 2)
	     { DrawASCII.PlayerVSAI("scissors", "rock"); }
	         

	}

	if ( aiMove == 2 )
	{ 
	
             if ( playerMove == 0 )
	     { DrawASCII.PlayerVSAI("paper", "scissors"); }

	     if ( playerMove == 1 )
	     { DrawASCII.PlayerVSAI("rock", "scissors"); }

	     if ( playerMove == 2 )
	     { DrawASCII.PlayerVSAI("scissors", "scissors"); }

	}

	Console.ReadKey(true);



	if ( aiMove == 0 && playerMove == 0 )
	{ DrawMessage("draw"); }

        if ( aiMove == 0 && playerMove == 1 )
	{ DrawMessage("lose"); }

	if ( aiMove == 0 && playerMove == 2 )
	{ DrawMessage("win"); }



	if ( aiMove == 1 && playerMove == 1 )
	{ DrawMessage("draw"); }
	
	if ( aiMove == 1 && playerMove == 0 )
	{ DrawMessage("win"); }

	if ( aiMove == 1 && playerMove == 2 )
	{ DrawMessage("lose"); }



	if ( aiMove == 2 && playerMove == 2 )
	{ DrawMessage("draw"); }

	if ( aiMove == 2 && playerMove == 1 )
	{ DrawMessage("win"); }

	if ( aiMove == 2 && playerMove == 0 )
	{ DrawMessage("lose"); }

    }


    
    private static void DrawMessage( string messageToWrite )
    { 

         Console.Clear();

         if ( messageToWrite == "draw" )
	 { 

             Console.ForegroundColor = ConsoleColor.White;
	     Console.WriteLine(@"
██████  ██████   █████  ██     ██                    ██ 
██   ██ ██   ██ ██   ██ ██     ██             ██    ██  
██   ██ ██████  ███████ ██  █  ██                  ██   
██   ██ ██   ██ ██   ██ ██ ███ ██             ██  ██    
██████  ██   ██ ██   ██  ███ ███                 ██ 			     
			       ");

	 }

	 
	 if ( messageToWrite == "win" )
	 { 

	     Console.ForegroundColor = ConsoleColor.Cyan;
	     Console.WriteLine(@"
██     ██ ██ ███    ██                ██  
██     ██ ██ ████   ██             ██  ██ 
██  █  ██ ██ ██ ██  ██                 ██ 
██ ███ ██ ██ ██  ██ ██             ██  ██ 
 ███ ███  ██ ██   ████                ██			     
			       ");

	 }

	 if ( messageToWrite == "lose" )
	 { 
	 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
██       ██████  ███████ ███████                 ██ 
██      ██    ██ ██      ██                  ██ ██  
██      ██    ██ ███████ █████                  ██  
██      ██    ██      ██ ██                  ██ ██  
███████  ██████  ███████ ███████                 ██			    
			      ");

	 }

    }

}
