using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public DifficultySO CurrentDifficulty;
    public static DifficultyManager Instance;

    public DifficultySO easy;
    public DifficultySO medium;
    public DifficultySO hard;

    public void OnEasy()
    {
        CurrentDifficulty = easy;
    }

    public void OnMedium()
    {
        CurrentDifficulty = medium;
    }

    public void OnHard()
    {
        CurrentDifficulty = hard;
    }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetDifficulty(DifficultySO difficulty)
    {
        CurrentDifficulty = difficulty;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
