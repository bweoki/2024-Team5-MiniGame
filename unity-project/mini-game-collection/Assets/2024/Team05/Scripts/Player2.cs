using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2024.Team05
{


    public class Player2 : MonoBehaviour
    {
        // Variables
        float x;
        public float speed = 5f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            x = ArcadeInput.Player2.AxisX;
        }

        private void FixedUpdate()
        {
            Vector3 move = new Vector3(x, 0, 0);
            // Direction and distance
            transform.Translate(move * speed * Time.deltaTime);
        }
    }
}
