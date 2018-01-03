using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    private int timesHit;
    public AudioClip pow;
    public Sprite[] hitSprites;
    public static int brickCount = 0;
    private bool isBreakable;

    private LevelManager levelManager;

    void Start() {
        timesHit = 0;
        isBreakable = (this.tag == "Breakable");
        if (isBreakable) {
            brickCount++;
        }
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(pow, transform.position);
        if (isBreakable)
        {
            HitHandler();
        }
    }

    void HitHandler()
    {
        timesHit++;
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
        {
            brickCount--;
            levelManager.BricksDestroyed();
            print(brickCount);
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    private void LoadSprites() {
        int spriteIndex = timesHit -1;
        this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }
}
