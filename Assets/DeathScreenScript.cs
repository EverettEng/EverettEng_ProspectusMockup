using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DeathScreenScript : MonoBehaviour
{
    public float timer = 0;
    public string text1String;
    public string text2String;
    public string text3String;
    public string text4String;
    public string text5String;
    public char[] text1;
    public char[] text2;
    public char[] text3;
    public char[] text4;
    public char[] text5;
    public TMP_Text deathText;
    int b = 0;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        text1String = "Initiating cloning sequence...";
        text2String = "Transferring consciousness...";
        text3String = "Finding new host...";
        text4String = "Body found. Thawing process started...";
        text5String = "Cloning process complete.";
        text1 = text1String.ToCharArray();
        text2 = text2String.ToCharArray();
        text3 = text3String.ToCharArray();
        text4 = text4String.ToCharArray();
        text5 = text5String.ToCharArray();
        deathText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= 0.15f)
        {
            timer = 0;
            if (b == 0)
            {
                
                if(a >= text1.Length)
                {
                    deathText.text += "\n";
                    a = 0;
                    b++;
                }
                else
                {
                    deathText.text += text1[a].ToString();
                    a++;
                }
            }
            if (b == 1)
            {

                if (a >= text2.Length)
                {
                    deathText.text += "\n";
                    a = 0;
                    b++;
                }
                else
                {
                    deathText.text += text2[a].ToString();
                    a++;
                }
            }
            if (b == 2)
            {

                if (a >= text3.Length)
                {
                    deathText.text += "\n";
                    a = 0;
                    b++;
                }
                else
                {
                    deathText.text += text3[a].ToString();
                    a++;
                }
            }
            if (b == 3)
            {

                if (a >= text4.Length)
                {
                    deathText.text += "\n";
                    a = 0;
                    b++;
                }
                else
                {
                    deathText.text += text4[a].ToString();
                    a++;
                }
            }
            if (b == 4)
            {

                if (a >= text5.Length)
                {
                    deathText.text += "\n";
                    a = 0;
                    b++;
                }
                else
                {
                    deathText.text += text5[a].ToString();
                    a++;
                }
            }
        }
    }
}
