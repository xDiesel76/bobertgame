
// This is the timer, can use the functions to help other classes
// such as showing the time on screen

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerController : MonoBehaviour {
    public static TimerController instance;
    public TextMeshProUGUI timeCounter;
    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;
    private TimeSpan totalTime;

    private void Awake() {
        instance = this;
    }

    private void Start() {
        timeCounter.text = "Time: 00:00:00";
        BeginTimer();
    }

    public void BeginTimer() {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer() {
        timerGoing = false;
    }

    public TimeSpan GetTime() {
        return timePlaying;
    }

    private IEnumerator UpdateTimer() {
        while (timerGoing) {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm':'ss':'ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }
}
