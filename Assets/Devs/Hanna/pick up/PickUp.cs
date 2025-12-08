using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _Manager;
    public int Value;
   

    private void Start()
    {
        _Manager = GameObject.Find("GameManager").GetComponent<gamemanager>();
      
    }
    /// <summary>
    /// makes sure of value 
    /// </summary>
    public void StoneCount() 
    {
        Destroy(gameObject);
        _Manager.StoneCount++;
        CoinManager.instance.AddCoins(Value);
    }
}

