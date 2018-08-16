using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {


    void OnCollisionEnter(Collision colliderInfo) {
        if (colliderInfo.collider.tag == "Obstacle") {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManagerSrc>().GameOver();
        }
    }


}
