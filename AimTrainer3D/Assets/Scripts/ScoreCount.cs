using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    public static ScoreCount Instance;
    public int score = 0;
    public TextMeshProUGUI scoreText;

    public void addPoint(int point){
        score += point;
        scoreText.text = "Score: " + score;
        Debug.Log("Points added");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
