using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    public GameObject spawn;
    public Vector3 moveDirection;
    public float speed = 5f;
    public bool canJump;
    public Rigidbody rb;
    public float jumpForce = 5;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawn.transform.position;
        canJump = true;
        rb = GetComponent<Rigidbody>();
        if (!DataManager.done1)
        {
            SceneManager.LoadScene("Death Scene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");


        moveDirection = new Vector3(x, 0, z);
        transform.Translate(moveDirection * Time.deltaTime * speed);

    }

    void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
}
