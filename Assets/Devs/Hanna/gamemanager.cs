using Unity.VisualScripting;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    private level _level;
    [SerializeField] private int Stones = 5;
    public  int StoneCount = 0;
    public  GameObject[] _SpawnMinerals;
    private void Update()
    {
        StoneCheck();
    }
    void StoneCheck() 
    {
        if (StoneCount== 5) 
        {
            _level._Allminerals = true;
        }

            
    }

}
