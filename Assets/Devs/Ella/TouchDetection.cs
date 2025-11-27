using Unity.VisualScripting;
using UnityEngine;

public class TouchDetection : MonoBehaviour
{
    /// <summary>
    /// dis script is voor het detetcen van toutch via het scherm
    /// dit wekr ook met de muis en touch als goed is
    /// dit doe je doormiddel van een 3d raycast te sturen van de camera naar de plek die geslecteerd is
    /// !!!!VOEG WEL EEN 3D COLLIDER TOE AAN DE 2D GAMEOBJECTEN HIERVOOR!!!
    /// anders werkt het niet :(
    /// </summary>
    [SerializeField] private LineRenderer _lineRenderer;
   
    private void Start()
    {
        // LineRenderer instellingen zodat dit te zien is in de schene view
        _lineRenderer.startWidth = 0.005f;
        _lineRenderer.endWidth = 0.002f;
        _lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        _lineRenderer.material.color = Color.red; // Maak de lijn rood
    }

    private void Update()
    {
        CheckForTouchInput();
    }
    /// <summary>
    /// functie voor het detecten van muis en touch input voor andriod
    /// </summary>
    private void CheckForTouchInput()
    {   
        //kijk of er getikt is op het scherm
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == UnityEngine.TouchPhase.Began)
            { 
                Debug.Log("screen was touched");
                //haal positie van touch op en stuur een raycast ernaartoe
                DetectObject(touch.position);
            }
        }
        //kijk of er geklikt is op het scherm
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse button pressed");
            //haal de positie op van de klik en stuur een raycast ernaartoe
            DetectObject(Input.mousePosition);
        }
    }
    void DetectObject(Vector2 screenPOs)
    {
        // maak een raycast aan 
        Ray ray = Camera.main.ScreenPointToRay(screenPOs);
        RaycastHit hit;

        // begin linerenderer op de camera
        _lineRenderer.SetPosition(0, ray.origin);

        //functie om een raycast te tekenen naar het object en info op te halen
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Hit object: " + hit.collider.gameObject.name);
            // linerenderer eindigt hier
            _lineRenderer.SetPosition(1, hit.point);

            //haal object op
            GameObject hitOBJ = hit.collider.gameObject;

            //check of het object dat geraakt heeft gebrushed of gebreaked kan worden
            IBreakable breakable = hitOBJ.GetComponent<IBreakable>();
            IBrushable brushable = hitOBJ.GetComponent<IBrushable>();
            IGoToRockScene gotorock = hitOBJ.GetComponent<IGoToRockScene>();
            pickup pickup= hitOBJ.GetComponent<pickup>();
            shop Shop = hitOBJ.GetComponent<shop>();
            if ( breakable != null)
            {
                breakable.Break(1);
            }
            else if (brushable != null)
            {
                
                brushable.Brush(1);
            }
            else if (pickup !=null) 
            {
                pickup.StoneCount();
            }
            else if (Shop != null)
            {
                Shop.OpenShop();
                Shop.CloseShop();
                Shop.pickaxe();
            }
            else if (gotorock != null)
            {
                gotorock.GoToRockSceneHEHE();
            }
            else
            {
                Debug.Log("no breakable/brushable found!");
            }
        }
        else
        {
            // viualizeeer de lijn als de raycast niks raakt
            _lineRenderer.SetPosition(1, ray.origin + ray.direction * 10f);
            Debug.Log("No object detected");
        }
    }
}
