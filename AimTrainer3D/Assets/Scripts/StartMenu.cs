using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] GameObject startMenu;
    public DifficultySO easy;
    public DifficultySO medium;
    public DifficultySO hard;


    public void Easy(){
        DifficultyManager.Instance.SetDifficulty(DifficultyManager.Instance.easy);
        SceneManager.LoadScene("GameScene");
    }

    public void Medium(){
        DifficultyManager.Instance.SetDifficulty(DifficultyManager.Instance.medium);
        SceneManager.LoadScene("GameScene");
    }

    public void Hard(){
        DifficultyManager.Instance.SetDifficulty(DifficultyManager.Instance.hard);
        SceneManager.LoadScene("GameScene");
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Quit");
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
