using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class Diccionarios : MonoBehaviour
    {
        [Header("Content")] public GameObject[] mycontent;

        [Header("Dictionary")]
        public Dictionary<string, GameObject> characterDictionary;

        public Stack<GameObject> cardsStack;
        void Start()
        {
            characterDictionary = new Dictionary<string, GameObject>();
            for (int i = 0; i < mycontent.Length; i++)
            {
                characterDictionary.Add(mycontent[i].name,mycontent[i]);
            }
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
