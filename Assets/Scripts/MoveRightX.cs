using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float rightBound = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = FindObjectOfType<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }

        if (transform.position.x < rightBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }
    }
}
