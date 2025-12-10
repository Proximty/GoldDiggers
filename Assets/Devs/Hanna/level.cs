using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public bool _Allminerals = false;
    public  GameObject _UINextLevel;
    [SerializeField] private gamemanager _Manager;
    private SpawnGem _spawnGem;
    [SerializeField] private Stonerarity _stonteScipt;
    public GameObject _stoneInfo;
    public void Start()
    {
        _stonteScipt = GameObject.Find("Stone rarity").GetComponent<Stonerarity>();
    }
    public void Update()
    {
        Stones();
    }
    /// <summary>
    /// after the check it load the new level 
    /// </summary>
 
    public void Stones()
    {
        //if (_spawnGem.Animator.GetBool("Rotation") == true)
        //{
            if (_Allminerals == true)
            {  
              _stoneInfo.SetActive(true);
               if (_stoneInfo == true)
               {
                _UINextLevel.SetActive(true);
               }

            }
        //}
    }
    /// <summary>
    /// this makes the scene changes
    /// </summary>
   
}


