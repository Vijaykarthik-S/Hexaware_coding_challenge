using System;

namespace PetPals.Entity
{
    public class Dog : Pet
    {
        public string DogBreed { get; set; }

        public Dog(string name, int age, string breed, string dogBreed) : base( name, age, breed)
        {
            DogBreed = dogBreed;
        }

        public override string ToString()
        {
            return base.ToString() + $", Dog Breed: {DogBreed}";
        }
    }
}
