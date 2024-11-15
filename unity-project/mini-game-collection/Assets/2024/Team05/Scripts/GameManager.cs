using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameCollection.Games2024.Team05
{
    public class GameManager : MonoBehaviour
    {
        // MiniGameManager reference
        public MiniGameManager mGM;
        


        // Player references

        // Start is called before the first frame update
        // MiniGameKicker start
        private void Start()
        {
            mGM.StartGame();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
