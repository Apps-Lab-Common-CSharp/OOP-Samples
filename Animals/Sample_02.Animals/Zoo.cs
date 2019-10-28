﻿using System.Collections.Generic;

namespace Sample_02.Animals
{
    class Zoo
    {
        private readonly List<Animal> animals;

        public Zoo()
        {
            animals = new List<Animal>
            {
                new Animal("Lion", "Mammal", 200, 7),
                new Animal("Bear", "Mammal", 300, 10),
                new Animal("Cat", "Mammal", 50, 5),
                new Animal("Fish", "Aquarium", 10, 3),
            };
        }

        public void Update()
        {
            foreach (var animal in animals)
            {
                animal.Update();
            }
        }

        public void Feed(string name, int amount)
        {
            Animal animal = FindAnimalBy(name);
            if (animal != null)
            {
                animal.Eat(amount);
            }
        }

        private Animal FindAnimalBy(string name)
        {
            foreach (var animal in animals)
            {
                if (animal.Name.ToLower() == name.ToLower())
                {
                    return animal;
                }
            }

            return null;
        }
    }
}