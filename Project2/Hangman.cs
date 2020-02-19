
/*
* TASK:
*   Make a Program that plays a game of Hangman.
*   The word being guessed by the player can be hardcoded in the program. (Meaning the word is the same every time)
*   
*   Example Playthrough:
*   
    *         _____
    *        |     
    *        |
    *        |
    *        |___________
    *        
    *        _ _ _ _ _ _ _
    *        
    *       Guess a letter: A
    *       **************************
    *        _____
    *        |     
    *        |
    *        |
    *        |___________
    *        
    *        _ a _ _ _ _ _
    *        
    *       Guess a letter: t
    *       **************************
    *        _____
    *        |     
    *        |
    *        |
    *        |___________
    *        
    *        _ a t t _ _ _
    *        
    *       Guess a letter: t
    *       **************************
    *        _____
    *        |   O 
    *        |
    *        |
    *        |___________
    *        
    *        _ a t t _ _ _
    *        
    *       Guess a letter: x
    *       **************************
    *        _____
    *        |   O 
    *        |   |
    *        |
    *        |___________
    *        
    *        _ a t t _ _ _
    *        
    *       Guess a letter: y
    *       **************************
    *        _____
    *        |  \O 
    *        |   |
    *        |
    *        |___________
    *        
    *        _ a t t _ _ _
    *        
    *       Guess a letter: z
*  
*  I think you get where this is going.
*  
*  At the end of the game, ask the user if they want to play again
*  
    *        **************************
    *        _____
    *        |  \O 
    *        |   |
    *        |
    *        |___________
    *        
    *        m a t t h e w
    *        
    *       YOU WIN!
    *       Enter y to paly again:
*       
*  The player loses the game if the stick figuer is completly filled out. (They had 6 incorrect guesses)
    *        *************************
    *        _____
    *        |  \O/
    *        |   |
    *        |  / \
    *        |___________
    *        
    *        _ a t t h e w
    *        
    *       YOU LOSE!
    *       Enter y to paly again:
*   
*/
using System;

namespace Project2
{
    class Hangman
    {
        static void Main(string[] args)
        {
        }
    }
}
