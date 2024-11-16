using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NettspendScript : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public TMP_Text interactText;
    public TMP_Text nettspendDialogue;
    public bool text;
    public float timer;
    public StorageTerminalScript storageTerminal;
    public float cooldownTimer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        nettspendDialogue.text = "";
        text = false;
        timer = 0f;
        storageTerminal = GameObject.FindGameObjectWithTag("Storage Terminal").GetComponent<StorageTerminalScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!text)
        {
            cooldownTimer += Time.deltaTime;
        }
        if (text)
        {
            timer += Time.deltaTime;
        }
        distance = Vector3.Distance(player.transform.position, transform.position);
        if (distance <= 3)
        {
            if (!text)
            {
                interactText.text = "Press \"E\" to interact";
            }
            if (Input.GetKeyDown(KeyCode.E) && cooldownTimer >= 0.5f){
                cooldownTimer = 0;s
                interactText.text = "";
                nettspendDialogue.text = "Welcome back solider. Your consciousness has been transferred from your previous body to this one. Before I give you your salary, I have a mission for you. In the Gatinsir System, eliminate 3 drone complexes. Good luck.";
                text = true;
            }
        }
        else if (storageTerminal.distance <= 4)
        {
            if (!storageTerminal.text)
            {
                interactText.text = "Press \"E\" to interact";

                if (Input.GetKeyDown(KeyCode.E) && storageTerminal.cooldownTimer >= 0.5f)
                {
                    storageTerminal.cooldownTimer = 0;
                    storageTerminal.text = true;
                    interactText.text = "";
                    storageTerminal.storageTerminalImage.gameObject.SetActive(true);
                }
            }
            
        }
        else
        {
            interactText.text = "";
        }

        if (text && Input.GetKeyDown(KeyCode.E) && timer >= 2f)
        {
            timer = 0;
            nettspendDialogue.text = "";
            text = false;
        }
    }
}
