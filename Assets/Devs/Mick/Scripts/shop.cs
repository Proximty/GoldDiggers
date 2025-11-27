using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Button;
    public int pickaxeLevel;
    rock1 rock1;

    public void Start()
    {
        //Canvas.SetActive(false);
        pickaxeLevel = PlayerPrefs.GetInt("pickaxeLevel", 0);
        Debug.Log("pickaxeLevel");
    }
    public void OpenShop()
    {
       Canvas.SetActive(true);
       Button.SetActive(false);
    }
    public void CloseShop()
    {
        Canvas.SetActive(false);
        Button.SetActive(true);
    }
    public void pickaxe()
    {
      rock1.Break(+1);
    }
}
