using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimationScript : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject spawnCamera;
    public bool cutsceneFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        spawnCamera = GameObject.FindGameObjectWithTag("SpawnCutsceneCamera");
        spawnCamera.SetActive(true);
        mainCamera.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCamera.GetComponent<Transform>().position == new Vector3(-11.62f, 0.9729954f, 0.69f))
        {
            cutsceneFinished = true;
            mainCamera.SetActive(true);
            spawnCamera.SetActive(false);

        }
        
    }

}
