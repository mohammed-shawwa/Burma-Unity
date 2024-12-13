using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{

    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }
    }

    public interface IRunnable
    {
        void Run();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public interface ISwimmable
    {
        void Swim();
    }

    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }

        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }
    }

    public class Duck : Creature, IRunnable, ISwimmable
    {
        public void Run()
        {
            Debug.Log("Duck runs.");
        }

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }
    }

    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            Kangaroo kangaroo = new Kangaroo();
            Duck duck = new Duck();

            List<Creature> creatures = new List<Creature> { kangaroo, duck };
            foreach (var creature in creatures)
            {
                creature.Speak();
            }


            List<IRunnable> runners = new List<IRunnable> { kangaroo, duck };
            foreach (var runner in runners)
            {
                runner.Run();
            }

            List<IJumpable> jumpers = new List<IJumpable> { kangaroo };
            foreach (var jumper in jumpers)
            {
                jumper.Jump();
            }

            List<ISwimmable> swimmers = new List<ISwimmable> { duck };
            foreach (var swimmer in swimmers)
            {
                swimmer.Swim();
            }
        }



    }
}
