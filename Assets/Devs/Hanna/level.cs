using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public bool _Allminerals = false;
    public  GameObject _UINextLevel;
    [SerializeField] private gamemanager _Manager;
    private SpawnGem _spawnGem;

    public void Update()
    {
        Stones();
    }
    /// <summary>
    /// after the check it load the new level 
    /// </summary>
 
    public void Stones()
    {
        if (_spawnGem.Animator.GetBool("Rotation") == true)
        {
            if (_Allminerals == true)
            {
                _UINextLevel.SetActive(true);
            }
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


