using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class RockScriptManager : MonoBehaviour
{
    [SerializeField] private string sceneName;

    [Header("Delete rock bools")]
    [SerializeField] public bool DeleteRock1 = false;
    [SerializeField] public bool DeleteRock2 = false;
    [SerializeField] public bool DeleteRock3 = false;
    [SerializeField] public bool DeleteRock4 = false;
    [SerializeField] public bool DeleteRock5 = false;
    [SerializeField] public bool DeleteRock6 = false;
    [SerializeField] public bool DeleteRock7 = false;
    [SerializeField] public bool DeleteRock8 = false;

    [Header("piles")]
    [SerializeField] GameObject pile1;
    [SerializeField] GameObject pile2;
    [SerializeField] GameObject pile3;
    [SerializeField] GameObject pile4;
    [SerializeField] GameObject pile5;
    [SerializeField] GameObject pile6;
    [SerializeField] GameObject pile7;
    [SerializeField] GameObject pile8;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
    private void Update()
    {
        sceneName= SceneManager.GetActiveScene().name;


            switch (sceneName)
            {
                case "level 1":
                Debug.Log("You are in scene 1");
                #region find piles
                pile1 = GameObject.Find("pile 1");
                pile2 = GameObject.Find("pile 2");
                pile3 = GameObject.Find("pile 3");
                pile4 = GameObject.Find("pile 4");
                pile5 = GameObject.Find("pile 5");
                pile6 = GameObject.Find("pile 6");
                pile7 = GameObject.Find("pile 7");
                pile8 = GameObject.Find("pile 8");
                #endregion

                CheckIfPileDeleted(pile1, DeleteRock1);
                CheckIfPileDeleted(pile2, DeleteRock2);
                CheckIfPileDeleted(pile3, DeleteRock3);
                CheckIfPileDeleted(pile4 , DeleteRock4);
                CheckIfPileDeleted (pile5, DeleteRock5);
                CheckIfPileDeleted(pile6, DeleteRock6);
                CheckIfPileDeleted(pile7 , DeleteRock7);
                CheckIfPileDeleted(pile8 , DeleteRock8);


                break;
                case "SplashScreen":
                Debug.Log("You are in the SplashScreen");
                
                    break;
            }
    }

    private void CheckIfPileDeleted(GameObject pile, bool DeleteRock)
    {
        if(pile != null && DeleteRock == true)
        {
            Destroy(pile);
        }

    }
}
