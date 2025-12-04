using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class RockScriptManager : MonoBehaviour
{
    [SerializeField] private string sceneName;

    [SerializeField] private bool DeleteRock1 = false;
    [SerializeField] private bool DeleteRock2 = false;
    [SerializeField] private bool DeleteRock3 = false;
    [SerializeField] private bool DeleteRock4 = false;
    [SerializeField] private bool DeleteRock5 = false;
    [SerializeField] private bool DeleteRock6 = false;
    [SerializeField] private bool DeleteRock7 = false;
    [SerializeField] private bool DeleteRock8 = false;
    [SerializeField] private bool DeleteRock9 = false;

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
                    break;
                case "SplashScreen":
                Debug.Log("You are in the SplashScreen");
                //Destroy(this.gameObject);
                    break;
            }
    }
}
