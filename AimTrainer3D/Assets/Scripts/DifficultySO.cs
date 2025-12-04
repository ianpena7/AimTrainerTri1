using UnityEngine;

[CreateAssetMenu(fileName = "DifficultySO", menuName = "Scriptable Objects/DifficultySO")]
public class DifficultySO : ScriptableObject
{
    [Header("Bounds")]
    [Range(0.75f, 2.5f)]
    public float SpawnBoundaryMultiplier = 1f;
}
