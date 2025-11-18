using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class DiggingManager : MonoBehaviour
{
    [SerializeField] private bool _axeActive = false;
    [SerializeField] private rock1 _rockScipt;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _axePrefab;
    private Camera _mainCamera;
    private void Start()
    {
        _mainCamera = Camera.main;
        _rockScipt = this.gameObject.GetComponent<rock1>();
    }

    private void Update()
    {
        //update digging timer for animation
        _timer += Time.deltaTime;
        
    }

    public void enableAxe()
    {
        _axeActive = true;
    }

    
    private void OnMouseDown()
    {
        Debug.Log("Plz Dig");
        if(_axeActive == true && _timer >=0.3f)
        {
            _rockScipt.Break();
            //activate axe anim
            Instantiate(_axePrefab);
            _timer = 0f;
        }
        
    }
}
