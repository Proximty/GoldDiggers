using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using static UnityEngine.UI.Image;

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
    [SerializeField] GameObject rock1;
    [SerializeField] GameObject rock2;
    [SerializeField] GameObject rock3;
    [SerializeField] GameObject rock4;
    [SerializeField] GameObject rock5;
    [SerializeField] GameObject rock6;
    [SerializeField] GameObject rock7;
    [SerializeField] GameObject rock8;

    //[Header("fossils shit")]
    //[SerializeField] public string pile1;
    //[SerializeField] public string pile2;
    //[SerializeField] public string pile3;
    //[SerializeField] public string pile4;
    //[SerializeField] public string pile5;
    //[SerializeField] public string pile6;
    //[SerializeField] public string pile7;
    //[SerializeField] public string pile8;

    //[Header("srting shit")]
    //[SerializeField] public string StoneChosen;
    //[SerializeField] public string GemFound;
    //[SerializeField] Stonerarity gemScript;

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
                rock1 = GameObject.Find("pile 1");
                //pile1 = rock1.GetComponent<RockInfo>().fossilName;
                rock2 = GameObject.Find("pile 2");
                //pile2 = rock2.GetComponent<RockInfo>().fossilName;
                rock3 = GameObject.Find("pile 3");
                //pile3 = rock3.GetComponent<RockInfo>().fossilName;
                rock4 = GameObject.Find("pile 4");
                //pile4 = rock4.GetComponent<RockInfo>().fossilName;
                rock5 = GameObject.Find("pile 5");
                //pile5 = rock5.GetComponent<RockInfo>().fossilName;
                rock6 = GameObject.Find("pile 6");
                //pile6 = rock6.GetComponent<RockInfo>().fossilName;
                rock7 = GameObject.Find("pile 7");
                //pile7 = rock7.GetComponent<RockInfo>().fossilName;
                rock8 = GameObject.Find("pile 8");
                //pile8 = rock8.GetComponent<RockInfo>().fossilName;
                #endregion


                ////spawn fossils at the place
                //GameObject thatrock = GameObject.Find(StoneChosen);
                //RockInfo rockInfo = GameObject.Find(StoneChosen).GetComponent<RockInfo>();
                //rockInfo.fossilName = GemFound;




                //detete chosen rocks

                CheckIfPileDeleted(rock1, DeleteRock1);
                CheckIfPileDeleted(rock2, DeleteRock2);
                CheckIfPileDeleted(rock3, DeleteRock3);
                CheckIfPileDeleted(rock4, DeleteRock4);
                CheckIfPileDeleted(rock5, DeleteRock5);
                CheckIfPileDeleted(rock6, DeleteRock6);
                CheckIfPileDeleted(rock7, DeleteRock7);
                CheckIfPileDeleted(rock8, DeleteRock8);

                break;


                //case "rocks":
                ////check wich fossil was spawned
                //gemScript = GameObject.Find("gem").GetComponent<Stonerarity>();
                //GemFound = gemScript.SelectedPrefab.tag;
                //    break;
                //case "fossils":
                ////check wich fossil was spawned
                //gemScript = GameObject.Find("gem").GetComponent<Stonerarity>();
                //GemFound = gemScript.SelectedPrefab.tag;
                //break;



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

    //function to set gem info

}
