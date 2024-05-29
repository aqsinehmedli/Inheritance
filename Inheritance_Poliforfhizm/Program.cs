using Inheritance_poliforfhizm;
using System.Data.Common;

Cat cats1 = new Cat("Tom", 2, "male", 10, 100, 5);
Cat cats2 = new Cat("Tommy", 3, "female", 10, 200, 5);

Dog dogs1 = new Dog("Jack", 4, "male", 5, 300, 10);
Dog dogs2 = new Dog("Jhon", 5, "female", 8, 500, 10);

Bird birds1 = new Bird("Bob", 1, "male", 3, 15, 4);
Bird birds2 = new Bird("Chip", 2, "female", 2, 25, 5);

Fish fishs1 = new Fish("Nemo", 3, "male", 12, 240, 15);
Fish fishs2 = new Fish("Oscar", 2, "female", 10, 340, 25);

PetShop myPetShop = new PetShop();
myPetShop.AddCat(cats1);
myPetShop.AddCat(cats2);

myPetShop.AddDog(dogs1);
myPetShop.AddDog(dogs2);

myPetShop.AddBird(birds1);
myPetShop.AddBird(birds2);

myPetShop.AddFish(fishs1);
myPetShop.AddFish(fishs2);
myPetShop.RemoveByNickname("Tom");


void Display()
{
    //while (myPetShop.Cats.Count<2)
    //{
        //Eat

        for (int i = 0; i < myPetShop.Cats.Count; i++)
        {
            if (myPetShop.Cats[i].Eat())
            {
                myPetShop.Cats[i].Energy++;
                myPetShop.Cats[i].Price++;
            }
        }
       

        for (int i = 0; i < myPetShop.Birds.Count; i++)
        {
            if (myPetShop.Birds[i].Eat())
            {
                myPetShop.Birds[i].Energy++;
                myPetShop.Birds[i].Price++;

            }
        }
        for (int i = 0; i < myPetShop.Dogs.Count; i++)
        {
            if (myPetShop.Dogs[i].Eat())
            {
                myPetShop.Dogs[i].Energy++;
                myPetShop.Dogs[i].Price++;
            }
        }

        for (int i = 0; i < myPetShop.Fishs.Count; i++)
        {
            if (myPetShop.Fishs[i].Eat())
            {
                myPetShop.Fishs[i].Energy++;
                myPetShop.Fishs[i].Price++;
            }
        }

        //Sleep


        for (int i = 0; i < myPetShop.Cats.Count; i++)
        {
            if (myPetShop.Cats[i].Sleep())
            {
                myPetShop.Cats[i].Energy++;
            }
        }
        for (int i = 0; i < myPetShop.Dogs.Count; i++)
        {
            if (myPetShop.Dogs[i].Sleep())
            {
                myPetShop.Dogs[i].Energy++;
            }
        }
        for (int i = 0; i < myPetShop.Birds.Count; i++)
        {
            if (myPetShop.Birds[i].Sleep())
            {
                myPetShop.Birds[i].Energy++;
            }
        }
        for (int i = 0; i < myPetShop.Fishs.Count; i++)
        {
            if (myPetShop.Fishs[i].Sleep())
            {
                myPetShop.Fishs[i].Energy++;
            }
        }

        //Play

        for (int i = 0; i < myPetShop.Cats.Count; i++)
        {
            if (myPetShop.Cats[i].Play())
            {
                myPetShop.Cats[i].Energy--;
                if (myPetShop.Cats[i].Energy == 0)
                {
                    myPetShop.Cats[i].Sleep();
                }
            }
        }
        for (int i = 0; i < myPetShop.Dogs.Count; i++)
        {
            if (myPetShop.Dogs[i].Play())
            {
                myPetShop.Dogs[i].Energy--;
                if (myPetShop.Dogs[i].Energy == 0)
                {
                    myPetShop.Dogs[i].Sleep();
                }

            }
        }
        for (int i = 0; i < myPetShop.Birds.Count; i++)
        {
            if (myPetShop.Birds[i].Play())
            {
                myPetShop.Birds[i].Energy--;
                if (myPetShop.Birds[i].Energy == 0)
                {
                    myPetShop.Birds[i].Sleep();
                }
            }
        }
        for (int i = 0; i < myPetShop.Fishs.Count; i++)
        {
            if (myPetShop.Fishs[i].Play())
            {
                myPetShop.Fishs[i].Energy--;
                if (myPetShop.Fishs[i].Energy==0)
                {
                    myPetShop.Fishs[i].Sleep();
                }
            }
        }
      
    //}


}

void AllEatQuantity()
{
    Console.Write("Quantity:");
    int quantity = 0;
    for (int i = 0; i < myPetShop.Cats.Count; i++)
    {
        quantity += myPetShop.Cats[i].MealQuantity;

    }
    for (int i = 0; i < myPetShop.Dogs.Count; i++)
    {
        quantity += myPetShop.Dogs[i].MealQuantity;

    }
    for (int i = 0; i < myPetShop.Birds.Count; i++)
    {
        quantity += myPetShop.Birds[i].MealQuantity;

    }
    for (int i = 0; i < myPetShop.Fishs.Count; i++)
    {
        quantity += myPetShop.Fishs[i].MealQuantity;

    }
    Console.WriteLine(quantity);
}

Display();
AllEatQuantity();
foreach (var cat in myPetShop.Cats)
{
    Console.WriteLine(cat);
    Console.WriteLine();

}
foreach (var fish in myPetShop.Fishs)
{
    Console.WriteLine(fish);
    Console.WriteLine();

}
foreach (var dog in myPetShop.Dogs)
{
    Console.WriteLine(dog);
    Console.WriteLine();

}
foreach (var bird in myPetShop.Birds)
{
    Console.WriteLine(bird);
    Console.WriteLine();

}