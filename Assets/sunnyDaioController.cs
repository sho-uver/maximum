using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunnyDaioController : MonoBehaviour {
    GameObject max;
    // Start is called before the first frame update
    void Start () {
        this.max = GameObject.Find ("max");

    }

    // Update is called once per frame
    void Update () {
        transform.position = new Vector3 ((max.transform.position.x - 10), 5.5f, 1);
    }
}