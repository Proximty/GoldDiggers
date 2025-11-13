using Unity.VisualScripting;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private gamemanager _manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
       _manager.StoneCount++;
    }
}
