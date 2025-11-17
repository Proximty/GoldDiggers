using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject Canvas;
    public int pickaxeLevel;

    public void Start()
    {
        //Canvas.SetActive(false);
        pickaxeLevel = PlayerPrefs.GetInt("pickaxeLevel", 0);
        Debug.Log("pickaxeLevel");
    }
    public void OpenShop()
    {
       Canvas.SetActive(true);
    }
    public void CloseShop()
    {
        Canvas.SetActive(false);
    }
    public void pickaxe()
    {
        pickaxeLevel++;
    }
}
