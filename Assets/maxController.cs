using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maxController : MonoBehaviour {

    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 750.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 6.0f;
    float speedx;

    void Start () {
        this.rigid2D = GetComponent<Rigidbody2D> ();
        this.animator = GetComponent<Animator> ();
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Space) && this.rigid2D.velocity.y == 0) {
            this.animator.SetTrigger ("JumpTrigger");
            this.rigid2D.AddForce (transform.up * this.jumpForce);
        }

        int key = 0;
        if (Input.GetKey (KeyCode.RightArrow)) {
            key = 1;
        }
        if (Input.GetKey (KeyCode.LeftArrow)) {
            key = -1;
        }

        this.speedx = Mathf.Abs (this.rigid2D.velocity.x);

        if (speedx < this.maxWalkSpeed) {
            this.rigid2D.AddForce (transform.right * key * this.walkForce);
        }

        if (key != 0) {
            transform.localScale = new Vector3 (key, 1, 1);
        }

        if (this.rigid2D.velocity.y == 0) {
            this.animator.speed = speedx / 8.0f;
        } else {
            this.animator.speed = 1.0f;
        }

        if (Input.GetKeyDown (KeyCode.A)) {
            this.animator.SetTrigger ("WanTrigger");
        }
    }
}