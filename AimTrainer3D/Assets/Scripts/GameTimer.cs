using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;


public class GameTimer : MonoBehaviour
{
public float timeRemaining = 30f; // set your starting time
public TextMeshProUGUI timerText; // assign in inspector

void Start()
{
StartCoroutine(TimerCountdown());
}

IEnumerator TimerCountdown()
{
float t = timeRemaining;

while (t > 0)
{
t -= Time.deltaTime;
UpdateTimerDisplay(t);
yield return null; // wait until next frame
}

// Timer finished
EndGame();
}

void UpdateTimerDisplay(float time)
{
if (time < 0) time = 0;

int minutes = Mathf.FloorToInt(time / 60);
int seconds = Mathf.FloorToInt(time % 60);

timerText.text = $"{minutes:00}:{seconds:00}";
}

void EndGame()
{
Debug.Log("GAME OVER – Timer finished!");
Cursor.lockState = CursorLockMode.None;
Cursor.visible = true;

// Load menu (or change to any scene you want)
SceneManager.LoadScene("Menu");
}
}