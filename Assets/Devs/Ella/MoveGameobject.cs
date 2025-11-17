using UnityEngine;

public class MoveGameobject : MonoBehaviour
{
    [SerializeField] private bool _isDragging = true;
    [SerializeField] public bool OnItem = false;
    [SerializeField] private brush Brush;
    [SerializeField] private rock1 _rockScript;
    [SerializeField] private dirt _dirtScipt;

    // Update is called once per frame
    void Update()
    {
        DoDraggingLogic();
    }

    
    private void OnMouseDown()
    {
        //if (OnItem == true)
        //{
        //    Brush.PlayerWantsToBrush = true;
        //}
        if(this.gameObject.name == "axe")
        {
            //Debug.Log("using axe");
            if (_rockScript.InRockArea)
            {
                _rockScript.Break();
            }
            //check if u are in the triggered area
            //if u are in the triggered area then activate the function

        }
        else if(this.gameObject.name == "brush")
        {
            //Debug.Log("using brush");
            Debug.Log("InBrushArea = " + _dirtScipt.InBrushArea);
            if (_dirtScipt.InBrushArea)
            {
                Debug.Log("brushing");
                _dirtScipt.Brush();
            }
        }
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
