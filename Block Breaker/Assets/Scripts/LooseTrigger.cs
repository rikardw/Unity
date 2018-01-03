using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseTrigger : MonoBehaviour {

    private LevelManager levelManager;

    void OnTriggerEnter2D (Collider2D trigger)
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Loose");
        Brick.brickCount = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }

}
