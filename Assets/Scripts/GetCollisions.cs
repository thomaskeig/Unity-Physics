using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCollisions : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision)
    {
        Debug.Log (collision.gameObject.name);
        if (collision.gameObject.name == "Wall3") {
            Debug.Log ("It's a hit");
        }
    } 
}
