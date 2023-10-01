using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rockpaperscissors
{
    class Program
    {
        static void Main(string[] args){

            string inputplayer, inputCpu;
            int randomint;
           
            bool playagain  = true;
            while(playagain){

             int scoreplayer = 0;
            int scorecpu = 0;

            while(scoreplayer < 3 && scorecpu < 3){

             

            Console.WriteLine("choose between Rock, Paper and Scissors");
            inputplayer=Console.ReadLine(); //takes input from player


            Random rnd = new Random();


            randomint = rnd.Next(1,4);

            switch(randomint)
            {
                case 1:
                inputCpu = "Rock";
                Console.WriteLine("Computer chose Rock");
                if(inputplayer=="Rock"){
                    Console.WriteLine("DRAW\n\n");
                }
                else if(inputplayer=="Paper"){
                    Console.WriteLine("Player Wins\n");
                    scoreplayer++;
                }
                else if(inputplayer=="Scissors"){
                    Console.WriteLine("CPU Wins\n");
                    scorecpu++;
                }
                break;
                case 2:
                inputCpu = "paper";
                Console.WriteLine("computer choose paper");

                 if(inputplayer=="Paper"){
                    Console.WriteLine("DRAW\n\n");
                }
                else if(inputplayer=="Rock"){
                    Console.WriteLine("Player Wins\n");
                    scoreplayer++;
                }
                else if(inputplayer=="Scissors"){
                    Console.WriteLine("CPU Wins\n");
                    scorecpu++;
                }
                
                break;

                case 3:
                inputCpu = "scissors";
                Console.WriteLine("computer choose Scissors");

                 if(inputplayer=="scissors"){
                    Console.WriteLine("DRAW\n\n");
                }
                else if(inputplayer=="Paper"){
                    Console.WriteLine("Player Wins\n");
                    scoreplayer++;
                }
                else if(inputplayer=="Rock"){
                    Console.WriteLine("CPU Wins\n");
                    scorecpu++;
                }
                break;

                default:
                Console.WriteLine("Invalid Entry");
                break;
            }
        }

        if(scoreplayer==3){
            Console.WriteLine("Player Won!");
        }
        else if(scorecpu==3){
            Console.WriteLine("Cpu Won!");
        }
        else{

        }
        
            Console.WriteLine("Do you want to play again<y/n>?");
            string loop = Console.ReadLine();
            if(loop=="y"){
                playagain = true;
            }
            else if(loop == "n"){
                playagain = false;
            }
            else{

            }
        }
    }
}
}




