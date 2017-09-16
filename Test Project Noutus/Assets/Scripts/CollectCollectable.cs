using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Collectable c = other.GetComponent<Collectable>();
        if (c != null)
        {
            c.Collect();
        }
    }
}
