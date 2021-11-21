﻿//
// Bachelor of Software Engineering
// Media Design School
// Auckland
// New Zealand
//
// (c) 2020 Media Design School
//
// File Name : InteractibleBase.cs
// Description : the base script all interactible scripts derive from, contains all the base for interactible objects
// Author : Aliexis Alvarez
// Mail : Aliexis.Alvarez@mediadesignschool.com
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interact
{
    public class InteractibleBase : MonoBehaviour, IInteractible   // base class that all interactible items derive from
    {
        #region Variables
            [Header ("Interact Settings")]
            public float holdDuration;
        
            public bool holdInteract;
            public bool multipleUse;
            public bool isInteractible;
            public bool destroyObj;



        #endregion
      
        #region Properties
            public float HoldDuration => holdDuration;

            public bool HoldInteract => holdInteract;

            public bool MultipleUse => multipleUse;

            public bool IsInteractible => isInteractible;

            public bool DestroyObj => destroyObj;
        #endregion 

        #region Classes
            public virtual void OnInteract()
            {
                //Debug.Log("INTERACTED: " + gameObject.name);
            }
        #endregion

        public GameObject player;

        void Start()
        {
            player = GameObject.Find("Player");
        }
    }
}



