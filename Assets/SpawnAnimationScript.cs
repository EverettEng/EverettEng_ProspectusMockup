using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationScript : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject spawnCamera;
    public bool cutsceneFinished = false;
    public GameObject player;
    public float distance;
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
        distance = Vector3.Distance(player.transform.position, spawnCamera.transform.position);
        if (distance <= 0.0001f)
        {
            cutsceneFinished = true;
            mainCamera.SetActive(true);
            spawnCamera.SetActive(false);

        }
        
    }

}
