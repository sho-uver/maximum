using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class risurisuController : MonoBehaviour {
    GameObject wan;
    float walkForce = 30.0f;
    float maxSpeed = 3.0f;
    Rigidbody2D rigid;
    GameObject max;
    // Start is called before the first frame update
    void Start () {
        this.rigid = GetComponent<Rigidbody2D> ();
        this.max = GameObject.Find ("max");
        this.wan = GameObject.Find ("wan");
    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Abs (rigid.velocity.x) < maxSpeed && max.transform.position.x < rigid.transform.position.x && Mathf.Abs (max.transform.position.x - rigid.transform.position.x) < 10) {
            rigid.AddForce (transform.right * walkForce * -1);
            transform.localScale = new Vector3 (0.5f, 0.5f, 1);
        } else if (rigid.velocity.x < maxSpeed && max.transform.position.x > rigid.transform.position.x) {
            rigid.AddForce (transform.right * walkForce);
            transform.localScale = new Vector3 (-0.5f, 0.5f, 1);
        }
        if (Mathf.Abs (max.transform.position.x - rigid.transform.position.x) < 1.0f && Mathf.Abs (max.transform.position.y - rigid.transform.position.y) < 0.5f) {
            SceneManager.LoadScene ("GameOverScene");
        }
    }
    void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.tag == "wan") {
            Destroy (gameObject);
        }
    }
}