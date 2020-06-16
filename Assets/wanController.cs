﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanController : MonoBehaviour {
    Rigidbody2D rigid;
    float moveForce = 1000.0f;
    GameObject player;

    // Start is called before the first frame update
    void Start () {
        this.rigid = GetComponent<Rigidbody2D> ();
        this.player = GameObject.Find ("max");
        if (player.transform.localScale.x == 0.5f) {
            transform.position = new Vector3 ((player.transform.position.x + 2), (player.transform.position.y), (player.transform.position.z));
        } else if (player.transform.localScale.x == -0.5f) {
            transform.position = new Vector3 ((player.transform.position.x - 2), (player.transform.position.y), (player.transform.position.z));
        }
        if (player.transform.localScale.x == 0.5f && Input.GetKey (KeyCode.A)) {
            rigid.AddForce (transform.right * moveForce);
            transform.localScale = new Vector3 (0.5f, 0.5f, 1);
        } else if (player.transform.localScale.x == -0.5f && Input.GetKey (KeyCode.A)) {
            rigid.AddForce (transform.right * moveForce * -1);
            transform.localScale = new Vector3 (-0.5f, 0.5f, 1);
        }
    }

    // Update is called once per frame
    void Update () {

        if (Mathf.Abs (player.transform.position.x - transform.position.x) > 15.0f) {
            Destroy (gameObject);
        }
    }
}