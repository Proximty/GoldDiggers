using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;


public class DiggingManager : MonoBehaviour
{
    [Header("Breaking Rocks")]
    public static bool AxeActive = false;
    [SerializeField] private rock1 _rockScipt;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _axePrefab;
    [SerializeField] private BrushManager _brushManagerScript;

    //[Header("Input")]
    //[SerializeField] private Vector2 screenPos;

    void Update()
    {

        _timer += Time.deltaTime;


        // Touch input
        if ((Touchscreen.current != null && Touchscreen.current.primaryTouch.press.isPressed))
        {
            Debug.Log("Touch detected");

            //screenPos = Touchscreen.current.primaryTouch.position.ReadValue();

        }
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            
            Debug.Log(
            Camera.main.ScreenPointToRay(Input.mousePosition));

            

            



        }
    }


    public void enableAxe()
    {
        AxeActive = true;
        _brushManagerScript.ActiveBrush = false;
    }

    
    private void OnMouseDown()
    {
        Debug.Log("Plz Dig");
        if (AxeActive == true && _timer >= 0.3f)
        {
            _rockScipt.Break(1);
            //activate axe anim
            Instantiate(_axePrefab);
            //verplaats gameobejct 

            Vector3 _objTransform = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(_objTransform.x + 0.2f, _objTransform.y + 0.2f, _objTransform.z);
            _timer = 0f;
        }

    }

    private void OnDrawGizmos()
    {
        
    }


}
