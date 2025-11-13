using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    [SerializeField] private bool _Allminerals = false;
    [SerializeField] private GameObject _UINextLevel;
    /// <summary>
    /// after the check it load the new level 
    /// </summary>
    public void Stones() 
    {

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


