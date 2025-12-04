using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // INVOKE
    public void Hit()
    {
        ScoreCount.Instance.addPoint(10);
        gameObject.SetActive(false);
        // Delay in respawn
        Invoke("Respawn", 0.5f);
    }
    public void Respawn(){
        gameObject.SetActive(true);
        transform.position = TargetBounds.Instance.GetRandomPosition();
        Debug.Log("Respawn Successful");
    }
}
