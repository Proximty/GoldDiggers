using UnityEngine;
using UnityEngine.SceneManagement;

public class catalogus : MonoBehaviour
{
    public void OpenCatalogus()
    {
        SceneManager.LoadScene("Catalogus");
    }

    public void CloseCatalogus()
    {
        Debug.Log("Closing catalogus and returning to Mick scene");
        SceneManager.LoadScene("Mick scene");
    }
}
