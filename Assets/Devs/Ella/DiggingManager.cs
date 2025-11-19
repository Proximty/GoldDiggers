using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class DiggingManager : MonoBehaviour
{
    public static bool AxeActive = false;
    [SerializeField] private rock1 _rockScipt;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _axePrefab;
    [SerializeField] private BrushManager _brushManagerScript;
   

    private void Update()
    {
        //update digging timer for animation
        _timer += Time.deltaTime;
        
    }  
    private void OnMouseDown()
    {
        Debug.Log("Plz Dig");
        if(AxeActive == true && _timer >=0.3f)
        {
            _rockScipt.Break();
            //activate axe anim
            Instantiate(_axePrefab);
            //verplaats gameobejct 

            Vector3 _objTransform = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(_objTransform.x + 0.2f, _objTransform.y + 0.2f, _objTransform.z);
            _timer = 0f;
        }
        
    }
    /// <summary>
    /// selects de Axe
    /// </summary>
    public void enableAxe()
    {
        AxeActive = true;
        _brushManagerScript.ActiveBrush = false;
    }
}
