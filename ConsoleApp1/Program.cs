Console.WriteLine("Welcome to ship game!");
Console.WriteLine("You are going to try to fit 3 spaceships into a container.");
Console.WriteLine("Do you want your ships to be big or small?: ");
string BigOrSmall = Console.ReadLine();
//denna del av koden introducerar spelaren och låter hen välja om de skeppen hen ska få in i containrar ska vara stora eller små

if (BigOrSmall == "small")
{
    SmallShip G1 = new SmallShip();
    SmallShip G2 = new SmallShip();
    SmallShip G3 = new SmallShip();
}
else if (BigOrSmall == "big")
{
    BigShip G1 = new BigShip();
    BigShip G2 = new BigShip();
    BigShip G3 = new BigShip();
}
//här så skapar koden 3 skepp som är små eller stora


