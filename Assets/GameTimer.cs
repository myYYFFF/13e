using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text timeText;
    private float startTime;
    private bool isRunning = true;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (!isRunning) return;

        float timeTaken = Time.time - startTime;
        if (timeText != null)
        {
            timeText.text = "Time: " + timeTaken.ToString("F2") + "s";
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public float GetFinalTime()
    {
        return Time.time - startTime;
    }
}
