using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ScriptableObject/Item",order = 0)]
    public class ItemSO : ScriptableObject
    {
        public Sprite sprite;

        public string title;

        public float price;

        public string GetPrice()
        {
            return String.Format("Price: {0}",price);
        }
    }
}
