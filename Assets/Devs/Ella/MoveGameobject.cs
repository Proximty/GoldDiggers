using UnityEngine;

public class MoveGameobject : MonoBehaviour
{
    /// <summary>
    /// voor het verplaatsen van objecten in het spel
    /// </summary>
    [SerializeField] private bool _isDragging = true;
    private void Update()
    {
        DoDraggingLogic();
    }

    //als de muis ingedrukt is dan ben je aan het verplaatsen
    private void OnMouseDown()
    {
        
        _isDragging = !_isDragging;
    }

    //als de muis niet ingedrukt is ben je gestopt met het verplaatsen van het gameobject
    private void OnMouseUp()
    {
        
        _isDragging = !_isDragging;
    }
   
    //deze functie voert de dragging logic uit
    private void DoDraggingLogic()
    {
        if (_isDragging)
        {
            Vector3 mouse = Input.mousePosition;

            //dit zorgt ervoor dat het object niet snapt naar de camera positie op de z axis
            mouse.z = Mathf.Abs(Camera.main.transform.position.z - transform.position.z);

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mouse);
            worldPos.z = transform.position.z; // hou de originele z cooordinaten voor 2d 

            transform.position = worldPos;
        }
    }
}
