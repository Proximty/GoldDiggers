using Unity.VisualScripting;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    [SerializeField] private level _level;
    public int StoneCount = 0;
    private void Update()
    {
        StoneCheck();
    }
    void StoneCheck()
    {
        if (StoneCount == 1)
        {
            _level._Allminerals = true;
        }


    }

}