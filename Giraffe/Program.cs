namespace Alu
{

    class Pui
    {


        public static void Main(string[] args)
        {
            Random random = new Random();
            bool playing=true;
            string player;
            string computer;

            while (playing)
            {

              player = "";
              computer = "";
                while(player!="ROCK" && player !="PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK /PAPER/SCISSORS:");
                    player=Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {

                    case 1:
                        computer = "ROCK";
                        break;
                        case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player:" + player);
                Console.WriteLine("Computer:" + computer);


                switch (player)
                {
                    case "ROCK":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("You  Lose");

                        }
                               
                        else if (computer== "SCISSORS")
                        {
                            Console.WriteLine("You Won");

                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                         break;
                        

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You  Won");

                        }

                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You Lose");

                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break ;


                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You  Lose");

                        }

                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Won");

                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                        




                }
               



            }

           




        }
            






    }





}

