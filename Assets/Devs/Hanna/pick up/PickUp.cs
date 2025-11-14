using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _manager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        _manager.StoneCount++;
        Destroy(gameObject);
    }
}

