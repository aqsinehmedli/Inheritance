namespace Inheritance_poliforfhizm;

public class Animals
{
    public string NickName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public int Energy { get; set; }
    public decimal Price { get; set; }
    public int MealQuantity { get; set; }


    public Animals(string nickName, int age, string gender, int energy, decimal price, int mealQuantity)
    {
        NickName = nickName;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }

    public override string ToString() =>

           $"Nickname:{NickName}\nAge:{Age}\nGender:{Gender}\nEnergy{Energy}\nPrice:{Price}\nMealQuantity:{MealQuantity}";


    public virtual bool Eat()
    {
        return true;
    }

    public virtual bool Sleep()
    {
        return true;
    }
    public virtual bool Play()
    {
        return true;
    }












}