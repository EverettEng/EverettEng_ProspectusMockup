using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 70f;
    public float xRot = 0f;
    public float minY = -90f;
    public float maxY = 90f;
    public bool spawnCutscene = true;
    public GameObject mainCamera;
    public GameObject spawnCamera;
    public GameObject cameraSettings;
    public SpawnAnimationScript spawnAnimationScript;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        cameraSettings = GameObject.FindGameObjectWithTag("CameraSettings");
        spawnAnimationScript = cameraSettings.GetComponent<SpawnAnimationScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (spawnAnimationScript.cutsceneFinished)
        {
            transform.position = player.position;
            MouseLook();
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void MouseLook()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, minY, maxY);

        transform.rotation = Quaternion.Euler(xRot, player.transform.eulerAngles.y, player.transform.eulerAngles.z);
        player.Rotate(Vector3.up * mouseX);
    }
}
