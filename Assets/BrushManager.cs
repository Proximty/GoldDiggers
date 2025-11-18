using UnityEngine;

public class BrushManager : MonoBehaviour
{
    public bool ActiveBrush = false;
    [SerializeField] private DiggingManager _diggingManagerScipt;
    private dirt _dirtScript;
    [SerializeField] private GameObject _brushPrefab;
    [SerializeField] private float _timer;

    private void Start()
    {
        _dirtScript = this.gameObject.GetComponent<dirt>();
    }

    private void Update()
    {
        //update digging timer for animation
        _timer += Time.deltaTime;

    }

    public void EnableBrush()
    {
        ActiveBrush = true;
        if (_diggingManagerScipt != null)
        {
            _diggingManagerScipt.AxeActive = false;
        }

    }

    private void OnMouseDown()
    {
        Debug.Log("Plz brush");
        if (ActiveBrush == true && _timer >= 0.5f)
        {
            _dirtScript.Brush();
            Instantiate(_brushPrefab);
            _timer = 0f;
        }
    }
}
