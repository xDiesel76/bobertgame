
// Script used for death
// If player touches an object with a tag of deadly it will trigger OnExplode()
// Also plays sound on death and activates game over screen

using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Explode : MonoBehaviour {
    public Debris debris;
    public AudioSource explode;
    [SerializeField] GameObject gameoverMenu;
    public int totalDebris = 10;
    void Update() {
        if (transform.position.y < -105) {
            OnExplode();
        }
    }
    void OnTriggerEnter2D(Collider2D target) {
        if (target.gameObject.tag == "Deadly") {
            OnExplode();

        }
    }

    void OnCollisionEnter2D(Collision2D target) {
        if (target.gameObject.tag == "Deadly") {
            OnExplode();
        }
    }

    void OnExplode() {
        var t = transform;
        explode.Play();
        TimerController.instance.EndTimer();

        for (int i = 0; i < totalDebris; i++) {
            t.TransformPoint(0, -100, 0);
            var clone = Instantiate(debris, t.position, Quaternion.identity) as Debris;
            var body2D = clone.GetComponent<Rigidbody2D>();
            body2D.AddForce(Vector3.right * Random.Range(-1000, 1000));
            body2D.AddForce(Vector3.up * Random.Range(5000, 2000));

        }
        Destroy(gameObject);
        gameoverMenu.SetActive(true);
    }
}
