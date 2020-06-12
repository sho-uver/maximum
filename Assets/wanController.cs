using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanController : MonoBehaviour {
    Rigidbody2D rigid;
    float moveForce = 60.0f;
    GameObject player;

    // Start is called before the first frame update
    void Start () {
        this.rigid = GetComponent<Rigidbody2D> ();
        this.player = GameObject.Find ("max");
    }

    // Update is called once per frame
    void Update () {
        if (player.transform.localScale.x == 1 && Input.GetKey (KeyCode.A)) {
            rigid.AddForce (transform.right * moveForce);
        } else if (player.transform.localScale.x == -1 && Input.GetKey (KeyCode.A)) {
            rigid.AddForce (transform.right * moveForce * -1);
        }
    }
}