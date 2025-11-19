//Cerine aish aljahdali 
//Jana Abdullah Alharbi
//Hajer Saleh AlAbbas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3_PetCare_System
{
    // Enum defining types of pets
    public enum PetType
    {
        Dog,
        Cat,
        Bird,
        Other
    }

    // Interface ICare defining pet care behaviors
    public interface ICare
    {
        string Feed();
        string Play();
    }

    // Abstract base class Pet implementing ICare interface
    public abstract class Pet : ICare
    {
        // Properties common to all pets
        public string Name { get; set; }
        public int Age { get; set; }
        public PetType Type { get; set; }

        // Constructor to initialize common properties

        public Pet(string name, int age, PetType type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        // Virtual method to display pet information, can be overridden by derived classes
        public virtual string DisplayInfo()
        {
            return "Name: " + Name + " Age: " + Age + " Type: " + Type;
        }

        // Abstract methods to be implemented by derived classes for pet care activities
        public abstract string Feed();
        public abstract string Play();
    }

    // Derived class Dog from base Pet
    public class Dog : Pet
    {
        // Constructor calling base constructor and initializing breed

        public Dog(string name, int age, string notes)
            : base(name, age, PetType.Dog)
        {
        }

        // Override to show dog specific details
        public override string DisplayInfo()
        {
            return base.DisplayInfo();
        }

        // Implementation of Feed behavior for dogs
        public override string Feed()
        {
            return Name + " the dog is being fed dog food.";
        }

        // Implementation of Play behavior for dogs
        public override string Play()
        {
            return Name + " the dog is playing fetch.";
        }
    }

    // Derived class Cat from base Pet
    public class Cat : Pet
    {
        // Constructor calling base and initializing IsIndoor property
        public Cat(string name, int age, string notes)
            : base(name, age, PetType.Cat)
        {
        }

        // Override to show cat specific details
        public override string DisplayInfo()
        {
            return base.DisplayInfo();
        }

        // Implementation of Feed behavior for cats
        public override string Feed()
        {
            return Name + " the cat is being fed cat food.";
        }

        // Implementation of Play behavior for cats
        public override string Play()
        {
            return Name + " the cat is playing with a ball of yarn.";
        }
    }

    public class Bird : Pet
    {
        // Additional property specific to birds

        // Constructor calling base constructor and initializing bType
        public Bird(string name, int age,string notes)
            : base(name, age, PetType.Bird)
        {
        }

        // Override to show dog specific details
        public override string DisplayInfo()
        {
            return base.DisplayInfo();
        }

        // Implementation of Feed behavior for birds
        public override string Feed()
        {
            return Name + " the bird is being fed bird food.";
        }

        // Implementation of Play behavior for birds
        public override string Play()
        {
            return Name + " the bird is playing.";
        }
    }



    public class PetManager
    {
        private ArrayList pets = new ArrayList();

        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public Pet SearchPet(string name)
        {
            foreach (var p in pets)
            {
                Pet pet = (Pet)p;
                if (pet.Name.ToLower() == name.ToLower())
                {
                    return pet;
                }
            }
            return null;
        }


        public bool DeletePet(string name)
        {
            var pet = SearchPet(name);
            if (pet != null)
            {
                pets.Remove(pet);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditPet(string name, Pet updatedPet)
        {
            var pet = SearchPet(name);
            if (pet != null)
            {
                int index = pets.IndexOf(pet);
                pets[index] = updatedPet;
                return true;
            }
            else
            {
                return false;
            }
        }
        public ArrayList GetAllPets()
        {
            return pets;
        }

        public void DisplayAllPets()
        {
            if (pets.Count == 0)
            {
                return;
            }
            foreach (var p in pets)
            {
                Pet pet = (Pet)p;
                pet.DisplayInfo();
            }
        }
    }
}
