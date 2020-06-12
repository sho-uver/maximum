using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanGenerator : MonoBehaviour {
        GameObject player;
        this.player = GameObject.Find ("max");
        // Update is called once per frame
        void Update () {
            if (Input.GetKey (KeyCode.A) && player.transform.localScale.x == 1) {
                GameObject attack = Instiate (arrowPrefab) as GameObject;
                attack.transform.position = new Vector3 ((player.transform.position.x + 5), 0, 0);
            } else if (Input.GetKey (KeyCode.A) && player.transform.localScale.x == -1) {
                GameObject attack = Instiate (arrowPrefab) as GameObject;
                attack.transform.position = new Vector3 ((player.transform.position.x - 5), 0, 0);
            }
        }