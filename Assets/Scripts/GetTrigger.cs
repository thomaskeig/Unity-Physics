using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTrigger : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Triggered");
        Debug.Log("Trigger: " + other.gameObject.name);

    } 
}
