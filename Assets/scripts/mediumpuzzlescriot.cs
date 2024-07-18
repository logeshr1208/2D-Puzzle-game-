using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class mediumpuzzlescriot : MonoBehaviour
{
    public bool gamestartbool;
    public bool swapends;
    public bool timmerstops;
    public bool ispauseds;

    public int blankindex; //array index
    public Image[] buttonimag;//random button image take and assign null
    [SerializeField] private int swapcount = 0;//click count 
    public GameObject gameoverimages;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private TextMeshProUGUI timmer;
    [SerializeField] private TextMeshProUGUI gameoverui;
    [SerializeField] private TextMeshProUGUI gameoverui1;
    [SerializeField] private TextMeshProUGUI gameoverui2;
    [SerializeField] private TextMeshProUGUI gameoverui3;
    public Sprite[] correctSprites;
    float time;
    [SerializeField] private int baseScore1 = 100; // Base score for completing the puzzle
   // [SerializeField] private int bonusPerMove1 = 2; // Bonus points for each move saved
    private int highScore;
    public Sprite img;
    public GameObject finalbuttonoff;
    public GameObject finalbuttonoff1;
    public GameObject finalbuttonoff2;

    [SerializeField] private sfx onebyoneaudio;
    private List<int> availablesprites = new List<int>();
    private void Start()
    {
        gamestartbool = false;
        swapends = true;
        timmerstops = true;
        blankindex = Random.Range(0, 15);
       // buttonimag[blankindex].sprite = null;
        buttonimag[blankindex].sprite =img;
        Debug.Log("random image " + blankindex);
        highScore = PlayerPrefs.GetInt("HighScore", 0);//playerprefs to store value

       // onebyoneaudio = GetComponent<sfx>();


        GameObject audioManagerObject = GameObject.Find("sfx");

        if (onebyoneaudio == null)
        {
            onebyoneaudio = audioManagerObject.GetComponent<sfx>();

        }
        else
        {
            Debug.Log("Audio component found successfully");
        }
    }
    private void Update()
    {
        TimmerOnNow();
    }
    public void TimmerOnNow()
    {
        if (timmerstops == true && gamestartbool == true)
        {
            time += Time.deltaTime;
            int minutes = Mathf.FloorToInt(time / 60);
            int sec = Mathf.FloorToInt(time % 60);
            timmer.text = string.Format("{0:00} :{1:00}", minutes, sec);
        }
    }

    public void startgame()
    {
        if (!gamestartbool)
        {
            gamestartbool = true;
            time = 0f;
            swapcount = 1;
            textMeshPro.text = "0";
        }
    }
    public void method0(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 1)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 4)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }

    }
    public void method1(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 0)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 2)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 5)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method2(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 1)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 3)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 6)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method3(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 2)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 7)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
        
            conditioncheck();
        }
    }

    public void method4(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 0)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 8)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 5)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }         
            conditioncheck();
        }
    }

    public void method5(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 1)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 4)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 9)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 6)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method6(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 5)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 7)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 2)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 10)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method7(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 3)
            {
                SwapImages(index, blankindex);
                blankindex = index;

            }
            else if (blankindex == 6)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 11)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method8(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 4)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 12)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 9)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method9(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 5)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 8)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 13)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 10)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method10(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 6)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 9)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 11)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 14)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method11(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 15)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 7)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 10)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method12(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 8)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 13)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method13(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 12)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 14)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 9)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method14(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 13)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 15)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 10)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    public void method15(int index)
    {
        startgame();
        if (gamestartbool == true)
        {
            if (blankindex == 14)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            else if (blankindex == 11)
            {
                SwapImages(index, blankindex);
                blankindex = index;
            }
            conditioncheck();
        }
    }
    private void SwapImages(int index1, int index2)
    {
        if (swapends == true)
        {
           
            textMeshPro.text = "" + swapcount++;
            Debug.Log(swapcount);
        }
        if (onebyoneaudio != null)
        {
            Debug.Log(" SWap audio");
            onebyoneaudio.swapclick();
        }
        Sprite temp = buttonimag[index1].sprite;  //random button image  null ...image
        buttonimag[index1].sprite = buttonimag[index2].sprite;//near by null ... original image
        buttonimag[index2].sprite = temp;
    }
    public void gameoverpanel()
    {
         finalbuttonoff.SetActive(false);
        finalbuttonoff1.SetActive(false);
        finalbuttonoff2.SetActive(false);
        if (onebyoneaudio != null)
        {
            onebyoneaudio.gameoverclip();
        }
        gameoverimages.SetActive(true);
    }

    public void conditioncheck()
    {
        bool solved = true;
        for (int i = 0; i < buttonimag.Length; i++)
        {
            if (i == blankindex)
            {
                Debug.Log("what happen");
                continue;
            }
            if (buttonimag[i].sprite != correctSprites[i]) //wrong array image && correct array sprite 
            {
                solved = false;
                return;
            }
        }
        if (solved == true)
        {
            buttonimag[blankindex].sprite = correctSprites[blankindex];
            Debug.Log("puzzle solved");
            gamestartbool = false;
            swapends = false;
            timmerstops = false;
            score();
            gameoverpanel();
        }
    }

    public void score()
    {
        int currentScore = baseScore1 + ( 60 - swapcount );

        gameoverui.text = " " + swapcount;
        gameoverui1.text = " " + timmer.text;
        gameoverui2.text = " " + currentScore;

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            gameoverui3.text = "";
        }
        else
        {
            gameoverui3.text = " " + highScore;
        }
    }
 


    public void RestartGame()
    {
        // Reset game state
        gamestartbool = true;
        swapends = true;
        timmerstops = true;
        swapcount = 0;
        time = 0f;

        availablesprites.Clear();
        for (int i = 0; i < correctSprites.Length; i++)
        {
            availablesprites.Add(i);
        }
        blankindex = Random.Range(0, 15);
        for (int i = 0; i < buttonimag.Length; i++)
        {
            if (i == blankindex)
            {
                buttonimag[i].sprite = null;
            }
            else
            {
                if (availablesprites.Count > 0)
                {
                    int randomIndex = Random.Range(0, availablesprites.Count);
                    int spriteIndex = availablesprites[randomIndex];
                    buttonimag[i].sprite = correctSprites[spriteIndex];
                    availablesprites.RemoveAt(randomIndex);
                }
                else
                {
                    buttonimag[i].sprite = correctSprites[Random.Range(0, correctSprites.Length)];
                }
            }
        }
            // Reset UI elements
            textMeshPro.text = "" + swapcount++;
        timmer.text = "";

        // Hide game over UI
        gameoverimages.SetActive(false);
      

        finalbuttonoff.SetActive(true);
        finalbuttonoff1.SetActive(true);
        finalbuttonoff2.SetActive(true);

        // Start the game timer
        StartCoroutine(StartTimer1());
    }

    private IEnumerator StartTimer1()
    {
        while (timmerstops)
        {
            yield return new WaitForSeconds(1f);
        
            timmer.text = " " + time.ToString("");
        }
    }

    public void quitgame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }




}


/* public void conditioncheck()
    {
    bool solved=true;
        for (int i = 0; i < buttonimag.Length; i++) {

            if (buttonimag[i].sprite != correctSprites[i])
            {
                Debug.Log("false");
               solved = false;
                break;
            }
 int calculatedScore;
    
    if (time <= 120) // 2 minutes or less
    {
        calculatedScore = 100;
    }
        }
        if (solved)
        {
            *//* int nullsprite = System.Array.IndexOf(correctSprites,null);
             Debug.Log(nullsprite);
             if (nullsprite != -1)
             {
                 buttonimag[nullsprite].sprite = null;
             }*//*
            buttonimag[blankindex].sprite = correctSprites[blankindex];
            Debug.Log(buttonimag[blankindex].sprite);
            Debug.Log("correct match");
            gamestartbool = false;
            swapend = false;
            gameoverpanel();
        }

        }  */

