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

    //go to the next image
    public void Next()
    {
        ClickSound();
        _fossils[currentImageIndex].SetActive(false);
        currentImageIndex++;
        if (currentImageIndex == _fossils.Count)
        {
            currentImageIndex = 0;
        }
        _fossils[currentImageIndex].SetActive(true);
            
        
    }
    //go to previous image
    public void Previous()
    {
        ClickSound();
        _fossils[currentImageIndex].SetActive(false);
        currentImageIndex--;
        if(currentImageIndex == -1)
        {
            currentImageIndex = _fossils.Count - 1;
        }
        _fossils[currentImageIndex].SetActive(true);
        
    }

    public void ClickSound()
    {
        clickSound.Play();
    }

    

    

}
