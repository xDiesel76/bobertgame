
// Determines the button pressed and the function that should be done

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Vector2 moving = new Vector2();
    public float elapsed = 0f;

    void Update() {
        moving.x = moving.y = 0;

        if (Input.GetKey("right")) {
            moving.x = 1;
        } else if (Input.GetKey("left")) {
            moving.x = -1;
        }

        if (Input.GetKey("up")) {
            moving.y = 1;
        } else if (Input.GetKey("down")) {
            moving.y = -1;
        }
    }


}
