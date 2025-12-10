using JetBrains.Annotations;
using Unity.Android.Gradle;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catalogus : MonoBehaviour
{
    public int currentImageIndex = 0;
    public GameObject Ammonite;
    public GameObject AmmonietInfo;
    public GameObject KwartsInfo;
    public GameObject PyrietInfo;
    public GameObject SfalerietInfo;
    public AudioSource clickSound;
    public AudioSource PageTurning;

    public void Start()
    {
        currentImageIndex = 0;
        AmmonietInfo.SetActive(true);
        KwartsInfo.SetActive(false);
        PyrietInfo.SetActive(false);
        SfalerietInfo.SetActive(false);
    }
    public void Update()
    {
        NextImage();
    }
    public void OpenCatalogus()
    {
        SceneManager.LoadScene("Catalogus");
    }

    public void CloseCatalogus()
    {
        Debug.Log("Closing catalogus and returning to Mick scene");
        SceneManager.LoadScene("Mick scene");
    }
    public void NextImage()
    {
        if (currentImageIndex == 0)
        {
            AmmonietInfo.SetActive(true);
            KwartsInfo.SetActive(false);
            PyrietInfo.SetActive(false);
            SfalerietInfo.SetActive(false);
            Instantiate(Ammonite);
        }
        else if (currentImageIndex == 1)
        {
            AmmonietInfo.SetActive(false);
            KwartsInfo.SetActive(true);
            PyrietInfo.SetActive(false);
            SfalerietInfo.SetActive(false);
        }
        else if (currentImageIndex == 2)
        {
            AmmonietInfo.SetActive(false);
            KwartsInfo.SetActive(false);
            PyrietInfo.SetActive(true);
            SfalerietInfo.SetActive(false);
        }
        else if (currentImageIndex == 3)
        {
            AmmonietInfo.SetActive(false);
            KwartsInfo.SetActive(false);
            PyrietInfo.SetActive(false);
            SfalerietInfo.SetActive(true);
        }
    }
    public void Next()
    {
        ClickSound();
        PageTurnSound();
        currentImageIndex = currentImageIndex + 1;
        Debug.Log("het klik");
        Debug.Log(currentImageIndex);
    }

    public void Previous()
    {
        ClickSound();
        PageTurnSound();
        currentImageIndex = currentImageIndex - 1;
        Debug.Log("het klik");
        Debug.Log(currentImageIndex);
    }

    public void ClickSound()
    {
        clickSound.Play();
    }

    public void PageTurnSound()
    {
        PageTurning.Play();
    }

}
