using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class CustomObject
    {
        private int ID;
        private string Name;

        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not CustomObject)
            {
                return false;
            }

            CustomObject other = obj as CustomObject;
            return ID == other.ID && Name == other.Name;
        }

        // public static bool operator ==(CustomObject obj1, CustomObject obj2)
        // {
        //     if (obj1.Equals(null) || obj2.Equals(null))
        //     {
        //         return false;
        //     }
        //     return obj1.ID.Equals(obj2.ID) && obj1.Name.Equals(obj2.Name);
        // }

        // public static bool operator !=(CustomObject obj1, CustomObject obj2)
        // {
        //     if (obj1.Equals(null) || obj2.Equals(null))
        //     {
        //         return false;
        //     }

        //     return !obj1.ID.Equals(obj2.ID) || !obj1.Name.Equals(obj2.Name);
        // }

    }
}