using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAudioFromList : MonoBehaviour
{
    [SerializeField] private Stonerarity stoneScript;
    [SerializeField] private List<AudioSource> audioX = new List<AudioSource>();

    [SerializeField] private List<Texture> spriteX = new List<Texture>();
    [SerializeField] private RawImage garrySprite;

    void Start()
    {
        audioX[stoneScript.index].Play();
        garrySprite.texture = spriteX[stoneScript.index];
        
    }

    
}
