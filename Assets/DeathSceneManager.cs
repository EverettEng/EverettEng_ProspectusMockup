using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneManager : MonoBehaviour
{
    public DeathScreenScript deathScreenScript;
    public bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        deathScreenScript = GameObject.FindGameObjectWithTag("DeathScreen").GetComponent<DeathScreenScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (deathScreenScript.deathCutsceneDone)
        {
            done = true;
            deathScreenScript.deathCutsceneDone = false;
            DataManager.ChangeDone();
            SceneManager.LoadScene("Main Station");
        }
    }
}
