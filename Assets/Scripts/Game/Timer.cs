using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeElapsed = 0f;
    [SerializeField] TextMeshProUGUI timerText;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        // Format the time as a string.
        string minutes = Mathf.Floor(timeElapsed / 60).ToString("00");
        string seconds = Mathf.Floor(timeElapsed % 60).ToString("00");
        string milliseconds = Mathf.Floor((timeElapsed * 100) % 100).ToString("00");

        // Update the text to display the current time.
        timerText.text = "Time: " + minutes + ":" + seconds + ":" + milliseconds;
    }
}
