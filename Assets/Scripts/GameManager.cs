using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class GameManager: MonoBehaviour {

    List<KeyCode> letterKeys = new List<KeyCode>();

    public GameObject on;
    public GameObject gameOverMenu;
    public Text playerTimeText;

    private bool gameOver = false;
    private int randomNum = 0;
    private int letterCount = 10;
    private float startTime = 0f;
    private float playerTime = 0f;

    void Start ()
    {
        startTime = Time.time;
        randomNum = Random.Range(0, letterKeys.Count);

        letterKeys.Add(KeyCode.A);
        letterKeys.Add(KeyCode.B);
        letterKeys.Add(KeyCode.C);
        letterKeys.Add(KeyCode.D);
        letterKeys.Add(KeyCode.E);
        letterKeys.Add(KeyCode.F);
        letterKeys.Add(KeyCode.G);
        letterKeys.Add(KeyCode.H);
        letterKeys.Add(KeyCode.I);
        letterKeys.Add(KeyCode.J);
        letterKeys.Add(KeyCode.K);
        letterKeys.Add(KeyCode.L);
        letterKeys.Add(KeyCode.M);
        letterKeys.Add(KeyCode.N);
        letterKeys.Add(KeyCode.O);
        letterKeys.Add(KeyCode.P);
        letterKeys.Add(KeyCode.Q);
        letterKeys.Add(KeyCode.R);
        letterKeys.Add(KeyCode.S);
        letterKeys.Add(KeyCode.T);
        letterKeys.Add(KeyCode.U);
        letterKeys.Add(KeyCode.V);
        letterKeys.Add(KeyCode.W);
        letterKeys.Add(KeyCode.X);
        letterKeys.Add(KeyCode.Y);
        letterKeys.Add(KeyCode.Z);
    }
	
	void Update ()
    {
        if (!gameOver)
        {
            if (Input.GetKeyDown(letterKeys[randomNum]))
            {
                letterCount--;

                if (on.activeInHierarchy)
                    on.SetActive(false);
                else
                    on.SetActive(true);

                if (letterCount == 0)
                {
                    gameOver = true;
                    playerTime = Time.time - startTime;
                    playerTimeText.text = "TIME: " + playerTime + "s";
                    gameOverMenu.SetActive(true);
                }
                else
                    randomNum = Random.Range(0, letterKeys.Count);
            }
        }
	}
}
