//
// Bachelor of Software Engineering
// Media Design School
// Auckland
// New Zealand
//
// (c) 2020 Media Design School
//
// File Name : InputHandler.cs
// Description : Holds all the inputs for the player
// Author : Aliexis Alvarez
// Mail : Aliexis.Alvarez@mediadesignschool.com
//
using UnityEngine;

namespace Interact
{
    public class InputHandler : MonoBehaviour
    {
        #region Data
        [Header ("Input Data")]
        public InteractionInputData interactionInputData;

        #endregion


        // Start is called before the first frame update
        void Start()
        {
            interactionInputData.Reset();   // calls the reset function to set everything to default false;
        }

        // Update is called once per frame
        void Update()
        {
            getInteractionInputData();
        }   

        #region Custom Functions

        void getInteractionInputData()
        {
            interactionInputData.InteractClicked = Input.GetKeyDown(KeyCode.E); // calls function when E is pressed
            interactionInputData.InteractReleased = Input.GetKeyUp(KeyCode.E);  
        }
        
        #endregion
    }
}

