using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for " + name);
        Application.LoadLevel(name);
    }

    public void Quit()
    {
        Debug.Log("Quit requested.");
        Application.Quit();
    }

    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }

    public void BricksDestroyed()
    {
        if (Brick.brickCount <= 0) {
            LoadNextLevel();
        }
    }
}
