using Unity.VisualScripting;
using UnityEngine;

public class TouchDetection : MonoBehaviour
{

    [SerializeField] private LineRenderer _lineRenderer;

    private void Start()
    {


        // LineRenderer instellingen
        _lineRenderer.startWidth = 0.005f;
        _lineRenderer.endWidth = 0.002f;
        _lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        _lineRenderer.material.color = Color.red; // Maak de lijn rood
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == UnityEngine.TouchPhase.Began)
            {
                Debug.Log("screenw as touched");
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse button pressed");
            DetectObject(Input.mousePosition);
        }
    }
    void DetectObject(Vector2 screenPOs)
    {
        // Create a ray from the camera through the screen point
        Ray ray = Camera.main.ScreenPointToRay(screenPOs);
        RaycastHit hit;

        // Set start of line at the camera
        _lineRenderer.SetPosition(0, ray.origin);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Hit object: " + hit.collider.gameObject.name);
            // Line ends at the hit point
            _lineRenderer.SetPosition(1, hit.point);
        }
        else
        {
            // No hit: extend line to max distance
            _lineRenderer.SetPosition(1, ray.origin + ray.direction * 10f);
            Debug.Log("No object detected");
        }


    }
}
