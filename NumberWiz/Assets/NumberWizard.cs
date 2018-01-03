using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    int maxGuessesAllowed = 5;
    public Text text;
    int max;
    int min;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 100;
        min = 1;
        FirstGuess();
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    void NextGuess()
    {
        if (maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("win");
        }
        else
        {
            guess = Random.Range(min, max);
            text.text = "Ok, how about..." + guess.ToString() + "?";
            maxGuessesAllowed = maxGuessesAllowed - 1;
        }
    }
    void FirstGuess()
    {
        guess = Random.Range(min, max);
        text.text = "So how abouuut..." + guess.ToString() + "?";
        Debug.Log(guess);
    }
}