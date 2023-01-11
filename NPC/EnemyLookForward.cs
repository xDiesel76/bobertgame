
// Makes enemy turn at wall and at an edge, done by drawing a line in front of the enemy

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookForward : MonoBehaviour {
    public Transform sightStart, sightEnd;
    public string layer = "Solid";
    public bool needsCollision = true;
    private bool collision;

    void Update() {
        collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer(layer));
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
        if (collision == needsCollision) {
            transform.localScale = new Vector3(transform.localScale.x == 1 ? -1 : 1, 1, 1);
        }
    }
}
