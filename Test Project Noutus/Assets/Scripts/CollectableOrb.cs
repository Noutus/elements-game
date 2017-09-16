using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableOrb : MonoBehaviour, Collectable
{
    public OrbType Type;
    public enum OrbType
    {
        Death,
        Tech,
        Bio,
        Heat,
        Cold,
        MAX
    }
    
    public void Collect()
    {
        GameObject.Destroy(this.gameObject);
    }

    public void Pull(Vector3 target)
    {
        var distance = Vector3.Distance(this.transform.position, target);
        var speed = Time.deltaTime * (20 - distance);
        this.transform.position = Vector3.MoveTowards(this.transform.position, target, speed);
    }
}
