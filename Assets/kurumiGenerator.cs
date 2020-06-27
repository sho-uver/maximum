using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurumiGenerator : MonoBehaviour {
    public GameObject kurumiPrefab;

    void Update () {
        int count = GameObject.FindGameObjectsWithTag ("kurumi").Length;
        if (Input.GetKey (KeyCode.A) && count == 0) {
            GameObject attack = Instantiate (kurumiPrefab) as GameObject;
        }
    }
}