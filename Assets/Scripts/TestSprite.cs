using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Course
{
    public class TestSprite : MonoBehaviour
    {
        public Sprite character;

        public SpriteRenderer spriteRenderer;
        // Start is called before the first frame update
        void Start()
        {
            // Aqui no cambia dentro del editor, cambia en modo ejecucion.
            spriteRenderer.sprite = character;
        }
        private void OnValidate()
        {
            // aqui si que se refleja automaticamente en el editor el cambio que hecho 
            // de cambiar un sprite por otro dentro del editor
            spriteRenderer.sprite = character; 
        }
    }
    
}
