using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour
{
    public bool _Allminerals = false;
    [SerializeField] private gamemanager _Manager;
    private SpawnGem _spawnGem;
    [SerializeField] private Stonerarity _stonteScipt;
    public GameObject _stoneInfo;
    public SlideUpText _stoneInfoText;
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
        
            if (_Allminerals == true)
            {  
              _stoneInfo.SetActive(true);
            }
        

    }
    /// <summary>
    /// this makes the scene changes
    /// </summary>
   
}


