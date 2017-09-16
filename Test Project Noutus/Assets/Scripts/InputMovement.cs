using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovement : MonoBehaviour
{
    public float Speed = 0.33f;

	void FixedUpdate()
    {
        var horizontalMovement = Input.GetAxis(InputStrings.Horizontal) * this.Speed;
        var verticalMovement = Input.GetAxis(InputStrings.Vertical) * this.Speed;

        this.transform.Translate(horizontalMovement, 0, 0);
        this.transform.Translate(0, 0, verticalMovement);
	}
}
