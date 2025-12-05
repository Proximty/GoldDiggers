using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvl1Manger : MonoBehaviour
{
    [Header("rocks")]
    [SerializeField] private GameObject _rock1;
    [SerializeField] private GameObject _rock2;
    [SerializeField] private GameObject _rock3;
    [SerializeField] private GameObject _rock4;
    [SerializeField] private GameObject _rock5;
    [SerializeField] private GameObject _rock6;
    [SerializeField] private GameObject _rock7;
    [SerializeField] private GameObject _rock8;

    [Header("the rest")]
    [SerializeField] private string _sceneName;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        // Retrieve the name of this scene
        Scene currentScene = SceneManager.GetActiveScene();
        _sceneName = currentScene.name;

        //get the rock gameobejcts
        if (_sceneName == "level 1")
        {
            for (int i = 0; i < 7; i++) 
            {
                //get the rocks
                
            }
            Debug.Log("Currenlty in level 1");

        }
    }
    void Update()
    {
        
        //else
        //{
        //    Debug.Log("You are running : " +_sceneName);
        //}
        
    }
}
