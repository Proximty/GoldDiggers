using UnityEngine;

public class MoveGameobject : MonoBehaviour
{
    [SerializeField] private bool _isDragging = true;

    // Update is called once per frame
    void Update()
    {
        DoDraggingLogic();
    }

    
    private void OnMouseDown()
    {
        
        _isDragging = !_isDragging;
    }

    private void OnMouseUp()
    {
        
        _isDragging = !_isDragging;
    }

    private void DoDraggingLogic()
    {
        if (_isDragging)
        {
            Vector3 mouse = Input.mousePosition;

            // Use your object's Z position so it doesn't snap to the camera plane.
            mouse.z = Mathf.Abs(Camera.main.transform.position.z - transform.position.z);

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mouse);
            worldPos.z = transform.position.z; // keep original Z for 2D

            transform.position = worldPos;
        }
    }
}
