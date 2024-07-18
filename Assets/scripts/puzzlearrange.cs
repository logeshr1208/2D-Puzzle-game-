
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class puzzlearrange : MonoBehaviour
{
    public bool gamestart;
    public bool swapend;
    public bool timmerstop;
    public bool  ispaused=false;
    public bool playSoundEffects = true;
    public int emptyindex; //array index
    private int highScore;
    float time;
    [SerializeField] private int swapcount = 0;//click count 
    public Image[] buttonimag;//random button image take and assign null
    public Sprite[] correctSprites;
    [SerializeField] private GameObject gameoverimage;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private TextMeshProUGUI timmer;
    [SerializeField] private TextMeshProUGUI gameoveruiitem;
    [SerializeField] private TextMeshProUGUI gameoveruiitem1;
    [SerializeField] private TextMeshProUGUI gameoveruiitem2;
    [SerializeField] private TextMeshProUGUI gameoveruiitem3;   
    [SerializeField] private int baseScore = 100; // Base score for completing the puzzle
    public GameObject finalbutton;
   // public GameObject finalbutton1;
    public GameObject finalbutton2;
    [SerializeField] private sfx onebyoneaudio;
    onebyone stop;
    private List<int> availablesprite=new List<int> ();
    public Animator clip;
    private void Start()
    {
        gamestart = false;
        swapend = true;
        timmerstop = true;
        emptyindex = Random.Range(0, 9);
        buttonimag[emptyindex].sprite = null;
        timmer.text = "00:00";
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        stop = GetComponent<onebyone>();
       // onebyoneaudio = GetComponent<sfx>();

        GameObject audioManager = GameObject.Find("audio");
        GameObject audioManagerObject = GameObject.Find("sfx");
   // clip=    GetComponent<Animator>();

        if (onebyoneaudio == null)
        {
            onebyoneaudio = audioManagerObject.GetComponent<sfx>();
            stop=audioManager.GetComponent<onebyone>();
           
        }
        else
        {
            Debug.Log(" component found successfully");
        }
      
    }
    private void Update()
    {
        TimmerOnNow();
    }
    public void TimmerOnNow()
    {
        if (timmerstop == true && gamestart==true)
        {
            time += Time.deltaTime;
            int minutes = Mathf.FloorToInt(time / 60);
            int sec = Mathf.FloorToInt(time % 60);
            timmer.text = string.Format("{0:00} :{1:00}", minutes, sec);
        }
    } 
    public void startgame()
    {
        if (!gamestart)
        {
            gamestart = true;
            time = 0f;
            swapcount = 1;
            textMeshPro.text = "0";
        }
    }
    public void method0(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 1)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 3)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
           
            conditioncheck();
        }

    }
    public void method1(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 0)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 2)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 4)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
           
            conditioncheck();
        }
        
    }
    public void method2(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 1)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 5)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
          
            conditioncheck();
        }
    }
    public void method3(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 0)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 4)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 6)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            
            conditioncheck();
        }
    }

    public void method4(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 1)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 3)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 5)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 7)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
           
            conditioncheck();
        }
    }

    public void method5(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 2)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 4)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 8)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            
            conditioncheck();
        }
    }
    public void method6(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 3)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 7)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
           
            conditioncheck();
        }
    }
    public void method7(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 4)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;

            }
            else if (emptyindex == 6)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 8)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            
            conditioncheck();
        }
    }
    public void method8(int index)
    {
        startgame();
        if (gamestart == true)
        {
            if (emptyindex == 5)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
            else if (emptyindex == 7)
            {
                SwapImages(index, emptyindex);
                emptyindex = index;
            }
          
            conditioncheck();
        }
    }
    private void SwapImages(int index1, int index2)
    {
        if (swapend == true)
        {
            textMeshPro.text = ""+ swapcount++;         
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
    public void conditioncheck()
    {
        bool solved = true;
        for (int i = 0; i < buttonimag.Length; i++)
        {    
            if (i == emptyindex)//both are same place
            {
                Debug.Log("what happen");
                continue; 
            }    
            if (buttonimag[i].sprite != correctSprites[i]) //wrong array image && correct array sprite 
            {
                solved = false;
             //   Debug.Log("Puzzle not yet solved");
                return;
            }
        } 
        if (solved == true)
        {
            buttonimag[emptyindex].sprite = correctSprites[emptyindex];//last sprite 
            Debug.Log("puzzle solved");
            gamestart = false;
            swapend = false;
            timmerstop = false;
            score();
            gameoverpanel();
        }   
    }

    public void score()
    {
        int currentScore = baseScore + (60-swapcount) ; 
        gameoveruiitem.text = " " + swapcount;
        gameoveruiitem1.text = " " + timmer.text;
        gameoveruiitem2.text = " " + currentScore;

        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt("HighScore", highScore);// playerprebs to set value
            gameoveruiitem3.text = "";
        }
        else
        {
            gameoveruiitem3.text = " " + highScore;
        }
    }

    public void RestartGame()  
    {
        gamestart = false;
        swapend = true;
        timmerstop = true;
        swapcount = 0;
        time = 0f;
        timmer.text = "00:00";

        availablesprite.Clear();
        for (int i = 0; i < correctSprites.Length; i++)
        {
availablesprite.Add(i);
        }




        emptyindex = Random.Range(0, 9);
        for (int i = 0; i < buttonimag.Length; i++)
        {
            if (i == emptyindex)
            {
                buttonimag[i].sprite = null;
            }
            else
            {
                if (availablesprite.Count > 0)
                {
                    int randomIndex = Random.Range(0, availablesprite.Count);
                    int spriteIndex = availablesprite[randomIndex];
                    buttonimag[i].sprite = correctSprites[spriteIndex];
                    availablesprite.RemoveAt(randomIndex);
                }
                else
                {                  
                    buttonimag[i].sprite = correctSprites[Random.Range(0, correctSprites.Length)];
                }
            }
        }      
        textMeshPro.text = " " + swapcount++;
        timmer.text = "";
        timmer.text = "";
        gameoverimage.SetActive(false);
        finalbutton.SetActive(true);//side button on
                                    // finalbutton1.SetActive(true);
        finalbutton2.SetActive(true);

        StartCoroutine(StartTimer());
    }
    public void gameoverpanel()
    {
        finalbutton.SetActive(false);//side button set active false
        finalbutton2.SetActive(false);
        if (onebyoneaudio != null)
        {
            onebyoneaudio.gameoverclip();
            //stop.StopGameOverClip();
        }    
        gameoverimage.SetActive(true);
    }  
    private IEnumerator StartTimer()
    {
        if (timmerstop==true)
        {
            yield return new WaitForSeconds(1f);
            timmer.text = "" + time.ToString("");
        }
    }

   
    public void quitgame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }

}
