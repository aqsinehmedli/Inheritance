
namespace Inheritance_poliforfhizm;

public class PetShop
{
    public List<Cat> Cats { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Bird> Birds { get; set; }
    public List<Fish> Fishs { get; set; }

    public PetShop(List<Cat> cats, List<Dog> dogs, List<Bird> birds, List<Fish> fishs)
    {
        Cats = cats;
        Dogs = dogs;
        Birds = birds;
        Fishs = fishs;
    }

    public PetShop()
    {
        Cats = new List<Cat>();
        Dogs = new List<Dog>();
        Birds = new List<Bird>();
        Fishs = new List<Fish>();
    }

    public void AddCat(Cat cat)
    {
        Cats.Add(cat);
    }

    public void AddDog(Dog dog)
    {
        Dogs.Add(dog);
    }

    public void AddBird(Bird bird)
    {
        Birds.Add(bird);
    }

    public void AddFish(Fish fish)
    {
        Fishs.Add(fish);
    }

    public void RemoveByNickname(string nickName)
    {
        for (int i = 0; i < Cats.Count; i++)
        {
            if (Cats[i].NickName == nickName)
            {
                Cats.RemoveAt(i);
                break;
            }
            else
            {
                Console.WriteLine("Listde bu adda pisik yoxdur!");
            }

        }
    }
}