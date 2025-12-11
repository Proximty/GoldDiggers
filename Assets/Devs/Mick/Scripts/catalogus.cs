using JetBrains.Annotations;
using System.Collections.Generic;
using Unity.Android.Gradle;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catalogus : MonoBehaviour
{
    public int currentImageIndex = 0;
    [SerializeField] private List<GameObject> _fossils = new List<GameObject>();
    public AudioSource clickSound;
    public AudioSource PageTurning;

    public void Start()
    {
        
    }
    public void Update()
    {

       
    }


    //go to the next image
    public void Next()
    {
        //ClickSound();
        //PageTurnSound();
        ClickSound();
        _fossils[currentImageIndex].SetActive(false);
        currentImageIndex++;
        if (currentImageIndex == _fossils.Count)
        {
            currentImageIndex = 0;
            _fossils[currentImageIndex].SetActive(true);

        }
        else
        {
            _fossils[currentImageIndex].SetActive(true);
            
            PageTurnSound();
        }
        
    
        
    }

    public void Previous()
    {
        ClickSound();
        PageTurnSound();
        
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
