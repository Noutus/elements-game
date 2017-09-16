using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    private Plane plane;

    void Start()
    {
        this.plane = new Plane(Vector3.up, Vector3.zero);
    }

    void FixedUpdate()
    {
        float distance = 0;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (this.plane.Raycast(ray, out distance))
        {
            var targetDirection = ray.GetPoint(distance) - this.transform.position;
            var newDirection = Vector3.RotateTowards(transform.forward, targetDirection, 1, 0);
            this.transform.rotation = Quaternion.LookRotation(newDirection);
        }
	}
}
