using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyManager : MonoBehaviour
{
   
    #region Singleton

    public static EnnemyManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject player;
}
