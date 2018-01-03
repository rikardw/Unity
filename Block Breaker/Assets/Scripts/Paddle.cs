using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        Vector3 paddlepos = new Vector3(0.5f, this.transform.position.y, 0f);

        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 15;
        paddlepos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 12.7f);
        this.transform.position = paddlepos;
        if (Input.GetKeyDown(KeyCode.W))
        {
            WinButton();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            NextLevelButton();
        }
    }
    public void WinButton()
    {
        Application.LoadLevel("Win");
    }
    public void NextLevelButton()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}