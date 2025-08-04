namespace Manticore_Final_Chapter_14_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ManticoreHealth = 10;
            int CitysHealth = 15;

            int RangeManticoreFromCity = RangeManticore();

            AttackManticore(ManticoreHealth, CitysHealth, RangeManticoreFromCity);

            int RangeManticore()
            {
                Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
                int range = Convert.ToInt32(Console.ReadLine()); //instead use try parse

                if(range > 100 || range < 0)
                {
                    Console.Write("Only 0 to 100 is suported \n");
                    Thread.Sleep(1500);
                    Console.Clear();
                    RangeManticore();
                }
                
                return range;
            }



            void AttackManticore(int ManticoreHealth, int CitysHealth, int RangeManticoreFromCity)
            {
                Console.Clear();
                Console.WriteLine("Player 1: \"Player 2, it is your turn.\"");
                for (int i = 1; ManticoreHealth > 0 && CitysHealth > 0; i++)
                {
                    byte damage = CalculationMultipleNumber(i);
                    
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine($"STATUS: Round: {i} City {CitysHealth}/15 Manticore: {ManticoreHealth}/10");
                    Console.WriteLine($"The cannon is expected to deal {damage} damage this round");
                    Console.Write($"Enter desired cannon range: ");
                    short rangeShoot = Convert.ToInt16(Console.ReadLine()); //verify here
                    string demageMenssage = chooseDamage(rangeShoot, RangeManticoreFromCity);
                    Console.WriteLine(demageMenssage);
                    bool hardDemage = damageCityOrManticore(rangeShoot, RangeManticoreFromCity, damage);
                    if (hardDemage)
                        ManticoreHealth -= damage;
                    else
                        CitysHealth -= damage;
                }

                howIsDestroyed(CitysHealth, ManticoreHealth);
            }

            byte CalculationMultipleNumber(int roundNumber)
            {
                if (roundNumber % 3 == 0)
                    return 3;
                else if (roundNumber % 5 == 0)
                    return 5;
                else if (roundNumber % 3 == 0 && roundNumber % 3 == 0)
                    return 10;

                return 1;
            }

            string chooseDamage(int RangeManticoreFromCity, int rangeShoot)
            {
                if (rangeShoot > RangeManticoreFromCity)
                    return "That round OVERSHOT the target.";
                else if (rangeShoot < RangeManticoreFromCity)
                    return "That round FELL SHORT of the target.";

                return "That round was a DIRECT HIT!";
            }

            bool damageCityOrManticore(short rangeShoot, int RangeManticoreFromCity, int damage)
            {
                if (rangeShoot > RangeManticoreFromCity)
                    return false;
                else if (rangeShoot < RangeManticoreFromCity)
                    return false;

                return true;
            }

            void howIsDestroyed(int CitysHealth, int ManticoreHealth)
            {
                if (ManticoreHealth == 0)
                    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved");
                else if (CitysHealth == 0)
                    Console.WriteLine("The City Console has been destroyed! The Mandicore win and you lost");

                //Decode song
                //All the things she said
            }
        }
    }
}
