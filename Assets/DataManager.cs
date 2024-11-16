using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager 
{
    public static DeathSceneManager deathSceneManager;
    public static bool done1 = false;
    // Start is called before the first frame update

    public static void Start()
    {
        deathSceneManager = GameObject.FindGameObjectWithTag("DeathScreen").GetComponent<DeathSceneManager>();
        
    }

    public static void ChangeDone()
    {
        done1 = true;
    }


    // Update is called once per frame

}
