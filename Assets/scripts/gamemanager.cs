using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{

  /*  public int I_EmptyIndex;

    public Button[] buttons;
    public bool IsNearEmpty(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("1st move");
                return I_EmptyIndex == 1 || I_EmptyIndex == 3;
            case 1:
                return I_EmptyIndex == 0 || I_EmptyIndex == 2 || I_EmptyIndex == 4;
            case 2:
                return I_EmptyIndex == 1 || I_EmptyIndex == 5;
            case 3:
                return I_EmptyIndex == 0 || I_EmptyIndex == 4 || I_EmptyIndex == 6;
            case 4:
                return I_EmptyIndex == 1 || I_EmptyIndex == 3 || I_EmptyIndex == 5 || I_EmptyIndex == 7;
            case 5:
                return I_EmptyIndex == 2 || I_EmptyIndex == 4 || I_EmptyIndex == 8;
            case 6:
                return I_EmptyIndex == 3 || I_EmptyIndex == 7;
            case 7:
                return I_EmptyIndex == 4 || I_EmptyIndex == 8 || I_EmptyIndex == 6;
            case 8:
                return I_EmptyIndex == 5 || I_EmptyIndex == 7;
            default:
                return false;
        }
    }

    public void CheckNearEmpty(int index)
    {
        bool result = IsNearEmpty(index);
        Debug.Log("IsNearEmpty for index " + index + ": " + result);

        if (result)
        {
            SwapImages(index, I_EmptyIndex);
            I_EmptyIndex = index;
        }
    }

    private void SwapImages(int index1, int index2)
    {

        
        Image img1 = buttons[index1].GetComponent<Image>();
        Image img2 = buttons[index2].GetComponent<Image>();


        Sprite tempSprite = img1.sprite;
        img1.sprite = img2.sprite;
       
        img2.sprite = tempSprite;
    }*/



public int emptyindex; //array index
    public Image[] buttonimag;//random button image take and assign null
    public int swapcount;//click count 
    public GameObject gameoverimage;
    public TextMeshPro textMeshPro;
    public bool randomcheck;
    public Sprite[] correctSprites; // correct sprites for comparison

    private void Start()
    {
        emptyindex = Random.Range(0, 9);
        buttonimag[emptyindex].sprite = null;
        Debug.Log("random image " + emptyindex);
    }

    public void method0(int index)
    {
        if (emptyindex == 1 || emptyindex == 3)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method1(int index)
    {
        if (emptyindex == 0 || emptyindex == 2 || emptyindex == 4)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method2(int index)
    {
        if (emptyindex == 1 || emptyindex == 5)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method3(int index)
    {
        if (emptyindex == 0 || emptyindex == 4 || emptyindex == 6)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method4(int index)
    {
        if (emptyindex == 1 || emptyindex == 3 || emptyindex == 5 || emptyindex == 7)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method5(int index)
    {
        if (emptyindex == 2 || emptyindex == 4 || emptyindex == 8)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method6(int index)
    {
        if (emptyindex == 3 || emptyindex == 7)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method7(int index)
    {
        if (emptyindex == 4 || emptyindex == 6 || emptyindex == 8)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    public void method8(int index)
    {
        if (emptyindex == 5 || emptyindex == 7)
        {
            SwapImages(index, emptyindex);
            emptyindex = index;
        }
        conditioncheck();
    }

    private void SwapImages(int index1, int index2)
    {
        Sprite temp = buttonimag[index1].sprite;  //random button image null ...image
        buttonimag[index1].sprite = buttonimag[index2].sprite;//near by null ... original image
        buttonimag[index2].sprite = temp;
    }

    public void gameoverpanel()
    {
        gameoverimage.SetActive(true);
    }

    public void conditioncheck()
    {
        bool isSolved = true;

        for (int i = 0; i < buttonimag.Length; i++)
        {
            if (buttonimag[i].sprite != correctSprites[i])
            {
                isSolved = false;
                break;
            }
        }

        if (isSolved)
        {
            gameoverpanel();
        }
    }
}







  








