using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]

public class PullCollectables : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        Collectable c = other.GetComponent<Collectable>();
        if (c != null)
        {
            c.Pull(this.transform.position);
        }
    }
}
