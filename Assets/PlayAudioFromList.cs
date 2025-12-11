using System.Collections.Generic;
using UnityEngine;

public class PlayAudioFromList : MonoBehaviour
{
    [SerializeField] private Stonerarity stoneScript;
    [SerializeField] private List<AudioSource> audioX = new List<AudioSource>();
    void Start()
    {
        audioX[stoneScript.index].Play();
    }

    
}
