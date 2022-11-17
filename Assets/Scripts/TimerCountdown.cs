using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerCountdown : MonoBehaviour
{
    public TMP_Text textDisplay;
    public int secondsLeft = 120;
    public bool takingAway = false;

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.SetText("00:" + secondsLeft);    
    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        float minutes = Mathf.FloorToInt(secondsLeft / 60);
        float seconds = Mathf.FloorToInt(secondsLeft % 60);
        if (seconds < 10)
        {
            textDisplay.SetText("0" +minutes+":0"+ seconds);
        }
        else
        {
            textDisplay.SetText("0"+minutes+":" + seconds);
        }
        takingAway = false;
    }
}
