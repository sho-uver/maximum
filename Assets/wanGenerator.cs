using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanGenerator : MonoBehaviour {
    public GameObject wanPrefab;

    void Update () {
        int count = GameObject.FindGameObjectsWithTag ("wan").Length;
        if (Input.GetKey (KeyCode.A) && count == 0) {
            GameObject attack = Instantiate (wanPrefab) as GameObject;
        }
    }
}