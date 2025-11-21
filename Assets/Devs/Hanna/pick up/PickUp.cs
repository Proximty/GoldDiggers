using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _manager;
    public void StoneCount() 
    {
        _manager.StoneCount++;
        Destroy(gameObject);
    }
}


