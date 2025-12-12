using System;
public class Program
{
    public static Random rng = new Random();
    public static void Main(string[] args)
    {
        Console.Clear();
        D20ForPlanes();
    }
    public static void D20ForPlanes()
    {
        Console.WriteLine("Roll a D20 by hitting enter!");
        while (2 > 1)
        {
            // 20 = A-10 Warthog
            // 19 = B-2 Spirit
            // 18 = F-15 Eagle
            // 17 = F-22 Raptor
            // 16 = F-16 Fighting Falcon
            // 15 = F4U Corsair
            // 14 = P-51 Mustang
            // 13 = P-47 Thunderbolt 
            // 12 = Messerschmitt Me 262
            // 11 = P-61 Black Widow 
            // 10 = XP-55 Ascender
            // 9 = B-17 Bomber
            // 8 = B-24 Bomber 
            // 7 = Junkers Ju 87 Stuka
            // 6 = Messerschmitt Bf 109
            // 5 = De Havilland DH.98
            // 4 = Polikarpov I-16 
            // 3 = Mitsubishi A6M Zero
            // 2 = Messerschmitt  Me 163B Komet
            // 1 = Heinkel He 162 Volksjäger
            int diceRoll = rng.Next(1,21);
            Console.ReadLine();
            Console.WriteLine(diceRoll);
            switch (diceRoll)
            {
                case 20:
                    Console.WriteLine("You get an A-10 Warthog!");
                    break;
                case 19:
                    Console.WriteLine("You get a B-2 Spirit!");
                    break;
                case 18:
                    Console.WriteLine("You get an F-15 Eagle!");
                    break;
                case 17:
                    Console.WriteLine("You get an F-22 Raptor!");
                    break;
                case 16:
                    Console.WriteLine("You get an F-16 Fighting Falcon!");
                    break;
                case 15:
                    Console.WriteLine("You get an F4U Corsair!");
                    break;
                case 14:
                    Console.WriteLine("You get a P-51 Mustang!");
                    break;
                case 13:
                    Console.WriteLine("You get a P-47 Thunderbolt!");
                    break;
                case 12:
                    Console.WriteLine("You get a Messerschmitt Me 262");
                    break;
                case 11:
                    Console.WriteLine("You get a P-61 Black Widow");
                    break;
                case 10:
                    Console.WriteLine("You get an XP-55 Ascender");
                    break;
                case 9:
                    Console.WriteLine("You get a B-17 Bomber");
                    break;
                case 8:
                    Console.WriteLine("You get a B-24 Bomber");
                    break;
                case 7:
                    Console.WriteLine("You get a Junkers Ju 87 Stuka");
                    break;
                case 6:
                    Console.WriteLine("You get a Messerschmitt Bf 109...");
                    break;
                case 5:
                    Console.WriteLine("You get a De Havilland DH.98...");
                    break;
                case 4:
                    Console.WriteLine("You get a Polikarpov I-16...");
                    break;
                case 3:
                    Console.WriteLine("You get a Mitsubishi A6M Zero...");
                    break;
                case 2:
                    Console.WriteLine("You get a Messerschmitt  Me 163B Komet...");
                    break;
                case 1:
                    Console.WriteLine("You get a Heinkel He 162 Volksjäger... Good luck...");
                    break;
                default:
                    break;
            }
        }
    }
}