using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class DiggingManager : MonoBehaviour
{
    public bool AxeActive = false;
    [SerializeField] private rock1 _rockScipt;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _axePrefab;
    [SerializeField] private BrushManager _brushManagerScript;
    private void Start()
    {
        _rockScipt = this.gameObject.GetComponent<rock1>();
    }

    private void Update()
    {
        //update digging timer for animation
        _timer += Time.deltaTime;
        
    }

    public void enableAxe()
    {
        AxeActive = true;
        _brushManagerScript.ActiveBrush = false;
    }

    
    private void OnMouseDown()
    {
        Debug.Log("Plz Dig");
        if(AxeActive == true && _timer >=0.3f)
        {
            _rockScipt.Break();
            //activate axe anim
            Instantiate(_axePrefab);
            _timer = 0f;
        }
        
    }
}
