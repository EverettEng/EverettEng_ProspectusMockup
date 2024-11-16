using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StorageTerminalScript : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public TMP_Text interactionText;
    public Image storageTerminalImage;
    public Color storageTerminalColor;
    public float timer;
    public bool text;
    public GameObject cube;
    public float cooldownTimer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        interactionText.text = "";
        storageTerminalColor = storageTerminalImage.color;
        storageTerminalColor.a = 0;
        cube = GameObject.FindGameObjectWithTag("Cube");
        storageTerminalImage.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (!text)
        {
            cooldownTimer += Time.deltaTime;
        }
        distance = Vector3.Distance(player.transform.position, cube.transform.position);
        if (text)
        {
            interactionText.text = "";
            timer += Time.deltaTime;
            if (timer >= 2 && Input.GetKeyDown(KeyCode.E))
            {
                storageTerminalImage.gameObject.SetActive(false);
                timer = 0;
                text = false;
            }
        }
    }
}
