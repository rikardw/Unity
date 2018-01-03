using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash_Screen : MonoBehaviour {

    private LevelManager levelManager;
    public int splashTimer;
    public string selectLevel;

    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(splashTimer);
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel(selectLevel);
    }
}
