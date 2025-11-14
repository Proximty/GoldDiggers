using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("PickedUp ");
        StoneCount();
       
        Destroy(gameObject);
    }
    private void StoneCount() 
    {
        _manager.StoneCount++;
    }
}


