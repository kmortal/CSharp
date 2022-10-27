using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float jumpSpeed = 20;
    private float auxSpeed = 30;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver != true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.transform.position.x < -15 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        if (playerControllerScript.isOnGround != true)
        {
            speed = jumpSpeed;
        }

        else
        {
            speed = auxSpeed;
        }
    }
}
