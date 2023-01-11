
// Destroys collectible and plays a sound when touched by player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour {
    public AudioSource collectible;

    void OnTriggerEnter2D(Collider2D target) {
        if (target.gameObject.tag == "Player") {
            collectible.Play();
            Destroy(gameObject);
        }
    }
}
