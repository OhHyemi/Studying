using System;
using System.Collections.Generic;
using System.Drawing;

namespace CSharpStudying
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFly> flyableAnimals = new List<IFly>();
            List<ISwim> swimableAnimals = new List<ISwim>();
            
            flyableAnimals.Add(new Sparrow(new Beak(1f, Color.Goldenrod)));
            flyableAnimals.Add(new Parrot(new Beak(10f, Color.Gold)));
            flyableAnimals.Add(new SugarGlider());
            
            swimableAnimals.Add(new Penguin(new Beak(15f, Color.Black)));
            
            MakeAnimalFly(flyableAnimals.ToArray());
            MakeAnimalSwim(swimableAnimals.ToArray());
        }

        static void MakeAnimalFly<T>(T[] flyableAnimals) where T:IFly
        {
            foreach (var animal in flyableAnimals)
            {
                animal.Fly();
            }
        }
        static void MakeAnimalSwim<T>(T[] swimableAnimals) where T:ISwim
        {
            foreach (var animal in swimableAnimals)
            {
                animal.Swim();
            }
        }
        // static void MakeAnimalFly(Animal[] flyableAnimals)//리스코프 치환원칙 위배
        // {
        //     foreach (var animal in flyableAnimals)
        //     {
        //         var flyable = animal as IFly;
        //         flyable?.Fly();
        //     }
        // }

    }
}