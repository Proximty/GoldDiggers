using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class pickup : MonoBehaviour
{
    [SerializeField] private gamemanager _manager;
    public int value;

    private void Start()
    {
        _manager = GameObject.Find("GameManager").GetComponent<gamemanager>();
    }
    public void StoneCount() 
    {
        _manager.StoneCount++;
        CoinManager.instance.AddCoins(value);
        Destroy(gameObject);
    }
}


