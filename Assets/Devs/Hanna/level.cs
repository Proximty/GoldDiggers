using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public  bool _Allminerals = false;
    [SerializeField] private GameObject _UINextLevel;
    [SerializeField] private gamemanager _Manager;
 

    /// <summary>
    /// after the check it load the new level 
    /// </summary>
    public void Stones() 
    {
        _Manager._SpawnMinerals(Random.Range(0, 10));
        if (_Allminerals == true) 
        {
           _UINextLevel.SetActive(true);
        }
    }
    /// <summary>
    /// this makes the scene changes
    /// </summary>
    public void NextScene()
    {
        SceneManager.LoadScene("");
    }
}


