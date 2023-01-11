
// Camera will follow player with a defined size by doing
// cam.orthographicSize = float

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject target;
    public float scale = 4f;

    private Transform t;
    void Awake() {
        var cam = GetComponent<Camera>();
        // cam.orthographicSize = 60.3156f;
    }
    void Start() {
        t = target.transform;
    }

    void Update() {
        if (target != null) {
            transform.position = new Vector3(t.position.x, t.position.y, transform.position.z);
        }
    }
}
