using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float elapsedTime;
    private float coolDown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // if the total elapsed time is greater than the cooldown, the player is allowed to send a dog
        if (elapsedTime > coolDown)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                // reset the elapsed time
                elapsedTime = 0.0f;
            }
        } 
        // if the total elapsed time is not enough to send a dog, the elapsed time is increased
        else {
            elapsedTime += Time.deltaTime;
        }
    }
}
