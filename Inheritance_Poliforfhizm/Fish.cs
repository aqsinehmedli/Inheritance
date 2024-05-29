namespace Inheritance_poliforfhizm;

public class Fish : Animals
{
    public Fish(string nickName, int age, string gender, int energy, decimal price, int mealQuantity) : base(nickName, age, gender, energy, price, mealQuantity) { }
    public override string ToString()
    {
        return base.ToString();
    }
    public override bool Eat()
    {
        return base.Eat();
    }
    public override bool Sleep()
    {
        return base.Sleep();
    }
}