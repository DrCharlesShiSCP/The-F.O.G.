using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGateOpen : MonoBehaviour
{
    public GameObject movingDoor2;

    public float maximumOpening = 10f;
    public float maximumClosing = 0f;

    public float movementSpeed = 5f;

    bool playerIsHere;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere == true)
        {
            if (movingDoor2.transform.position.x < maximumOpening)
            {
                movingDoor2.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);

            }
        }
        else
        {
            if (movingDoor2.transform.position.x > maximumClosing)
            {
                movingDoor2.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);

            }
            else
            {

            }
        }

        Debug.Log(movingDoor2.transform.position);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = true;
            Debug.Log("hi");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}

