using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurimicontroller : MonoBehaviour {
    Rigidbody2D rigid;
    GameObject risu;
    GameObject max;
    float moveforce = 1000.0f;
    // Start is called before the first frame update
    void Start () {
        this.rigid = GetComponent<Rigidbody2D> ();
        this.risu = GameObject.Find ("risurisu");
        this.max = GameObject.Find ("max");
        if (max.transform.position.x < risu.transform.position.x) {
            transform.position = new Vector3 ((risu.transform.position.x - 3), -1, 3);
            rigid.AddForce (transform.right * -1 * moveforce);
        } else if (max.transform.position.x > risu.transform.position.x) {
            transform.position = new Vector3 ((risu.transform.position.x + 3), -1, 3);
            rigid.AddForce (transform.right * moveforce);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Abs (rigid.transform.position.x - risu.transform.position.x) > 10.0f) {
            Destroy (gameObject);
        }
    }
}