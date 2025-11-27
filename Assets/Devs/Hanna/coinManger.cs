using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshPro;
    public int totalCoins;
    public static CoinManager instance;
    


    void Awake()
    {
        if (instance != null && instance != this) { Destroy(gameObject); return; }
        instance = this;
        //DontDestroyOnLoad(gameObject);



    }


    private void Update()
    {
        _LoadCoins();
    }

    /// <summary>
    /// Adds de stars as currentie
    /// </summary>
    /// <param name="amount"></param>
    public void AddCoins(int amount)
    {
        totalCoins += amount;
        
    }
    /// <summary>
    /// this is how you spend the currentie 
    /// </summary>
    /// <param name="amount"></param>
    public void SpendCoins(int amount)
    {
        totalCoins -= amount;
        if (totalCoins < 0) totalCoins = 0;
       
    }

    /// <summary>
    /// shows how much currentie you have 
    /// </summary>
    private void _LoadCoins()
    {
        textMeshPro.text = totalCoins.ToString();
    }
}
