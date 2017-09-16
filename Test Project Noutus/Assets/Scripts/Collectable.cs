using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Collectable
{
    void Collect();
    void Pull(Vector3 target);
}
