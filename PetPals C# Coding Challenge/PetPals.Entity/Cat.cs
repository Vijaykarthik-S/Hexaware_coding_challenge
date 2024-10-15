using System;

namespace PetPals.Entity
{
    public class Cat : Pet
    {
        public string CatColor { get; set; }

        public Cat( string name, int age, string breed, string catColor) : base(name, age, breed)
        {
            CatColor = catColor;
        }

        public override string ToString()
        {
            return base.ToString() + $", Cat Color: {CatColor}";
        }
    }
}
