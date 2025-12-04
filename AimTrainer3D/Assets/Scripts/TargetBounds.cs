using UnityEngine;

public class TargetBounds : MonoBehaviour
{
    private DifficultySO difficulty;
    
    //SINGLETON
    public static TargetBounds Instance;
    void Awake()
    {
        Instance = this;
    }

    [SerializeField] BoxCollider col;
    

    public Vector3 GetRandomPosition()
    {
        
        Vector3 center = col.center + transform.position;

        float Multiplier = difficulty.SpawnBoundaryMultiplier;

        float minX = center.x - (col.size.x * Multiplier);
        float maxX = center.x + (col.size.x * Multiplier);

        float minY = center.y - (col.size.y * Multiplier);    
        float maxY = center.y + (col.size.y * Multiplier);

        float minZ = center.z - col.size.z / 2f;
        float maxZ = center.z + col.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        return randomPosition;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        difficulty = DifficultyManager.Instance.CurrentDifficulty;

        if (DifficultyManager.Instance == null)
    {
        Debug.LogError("No DifficultyManager in scene!");
        return;
    }

    difficulty = DifficultyManager.Instance.CurrentDifficulty;

    if (difficulty == null)
        Debug.LogError("Difficulty not selected!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
