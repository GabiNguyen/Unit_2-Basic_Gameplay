using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    // When a GameObject collides with another GameObject, Unity calls OnTriggerEnter.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
