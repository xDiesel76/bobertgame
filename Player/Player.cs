
// All player movement is done here as well as the defined speeds

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 300f;
    public Vector2 maxVeolcity = new Vector2(60, 100);
    public float flySpeed = 300f;
    public bool standing;
    public float standingThreshold = 4f;
    public float airSpeedMultiplier = .3f;

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;
    private PlayerController controller;
    private Animator animator;

    void Start() {
        Application.targetFrameRate = 60;
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
        controller = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        var absVelx = Mathf.Abs(body2D.velocity.x);
        var absVely = Mathf.Abs(body2D.velocity.y);

        if (absVely <= standingThreshold) {
            standing = true;
        } else {
            standing = false;
        }

        var forceX = 0f;
        var forceY = 0f;

        if (controller.moving.x != 0) {
            if (absVelx < maxVeolcity.x) {
                var newSpeed = speed * controller.moving.x;
                forceX = standing ? newSpeed : (newSpeed * airSpeedMultiplier);
                renderer2D.flipX = forceX < 0;
            }
            animator.SetInteger("anim_state", 2);
        } else {
            animator.SetInteger("anim_state", 0);
        }

        if (controller.moving.y > 0) {
            if (absVely < maxVeolcity.y) {
                forceY = flySpeed * controller.moving.y;
            }
            animator.SetInteger("anim_state", 2);
        }

        body2D.AddForce(new Vector2(forceX, forceY));
    }
}
