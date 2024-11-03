using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationScript : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject spawnCamera;
    public bool cutsceneFinished = false;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        spawnCamera = GameObject.FindGameObjectWithTag("SpawnCutsceneCamera");
        player = GameObject.FindGameObjectWithTag("Player");
        spawnCamera.SetActive(true);
        mainCamera.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCamera.GetComponent<Transform>().position == player.GetComponent<Transform>().position)
        {
            cutsceneFinished = true;
            mainCamera.SetActive(true);
            spawnCamera.SetActive(false);

        }
        
    }

}
