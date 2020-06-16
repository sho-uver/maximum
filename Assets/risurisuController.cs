using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risurisuController : MonoBehaviour {
    float walkForce = 30.0f;
    float maxSpeed = 3.0f;
    Rigidbody2D rigid;
    GameObject max;
    // Start is called before the first frame update
    void Start () {
        this.rigid = GetComponent<Rigidbody2D> ();
        this.max = GameObject.Find ("max");
    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Abs (rigid.velocity.x) < maxSpeed && max.transform.position.x < rigid.transform.position.x) {
            rigid.AddForce (transform.right * walkForce * -1);
            transform.localScale = new Vector3 (0.5f, 0.5f, 1);
        } else if (rigid.velocity.x < maxSpeed && max.transform.position.x > rigid.transform.position.x) {
            rigid.AddForce (transform.right * walkForce);
            transform.localScale = new Vector3 (-0.5f, 0.5f, 1);
        }
    }
}