using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    private Camera cam;

    void Awake()
    {
        //auto assign camera if null
        cam = Camera.main;
        if (cam == null)
        {
            Debug.LogError("No main camera found in the scene!");
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Left Click!");

            // shoot ray from the mouse position
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 2f); 

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.GetComponent<Target>();

                if (target != null)
                {
                    Debug.Log("Target found");
                    // Destroy(target.gameObject);
                    target.Hit();
                }
            }
            else
            {
                Debug.Log("Ray hit nothing");
            }
        }
    }
}
