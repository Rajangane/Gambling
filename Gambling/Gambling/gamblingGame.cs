using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling
{
    public class gamblingGame
    {
        int money = 100;
        int bet = 1;
        public void Start()
        {
            int win = 0;
            int loss = 0;

            Console.WriteLine("Total Money Is :" + money);
            Random random = new Random();
            int toss = random.Next(0, 2);
            if (toss == 0)
            {
                win += bet;
                Console.WriteLine("Total Money after winning is {money + win} ");
            }
            else if(toss == 1)
            {
                loss = bet;
                Console.WriteLine("Total Money after lossing is {money + loss} ");
            }

        }

        
    }

}

