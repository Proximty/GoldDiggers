using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _manager;

    private void Start()
    {
        _manager = GameObject.Find("GameManager").GetComponent<gamemanager>();
    }
    public void StoneCount() 
    {
        _manager.StoneCount++;
        Destroy(gameObject);
    }
}


