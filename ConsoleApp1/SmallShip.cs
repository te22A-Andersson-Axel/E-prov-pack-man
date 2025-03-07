public class SmallShip : SpaceShip
{
    public void Smallship()
    {
        Size = Random.Shared.Next(0, 10);
    }
    //här så slumpas storleken av små skepp
}