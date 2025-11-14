using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _manager;
    private void OnTriggerEnter2D()
    {
        _manager.StoneCount++;
        Destroy(gameObject);
    }
}

