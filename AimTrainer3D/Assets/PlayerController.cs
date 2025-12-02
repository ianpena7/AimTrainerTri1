using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform cameraHolder; 

    [Header("Settings")]
    [SerializeField] private float mouseSensitivity = 2f;       

    private float verticalLookRotation = 0f;

    void Start()
    {
        LockCursor();
    }

    void Update()
    {
        if (Cursor.lockState != CursorLockMode.Locked || Cursor.visible)
        {
            LockCursor();
        }

        MouseAppearance();
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void MouseAppearance()
    {
        // Horizontal rotation 
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(Vector3.up * mouseX);

        // Vertical rotation
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalLookRotation -= mouseY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0f, 0f);
    }
}
