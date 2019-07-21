using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        Guess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        Guess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        Guess();
    }
    
 
    void Guess()
    {
        guess = Random.Range(min, max + 1);
        //guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
