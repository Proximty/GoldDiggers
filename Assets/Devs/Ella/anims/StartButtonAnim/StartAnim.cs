using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class StartAnim : MonoBehaviour
{
    //loop through a list and play each frame after x sec 
    [SerializeField] private List<Sprite> Sprites = new List<Sprite>();
    private Image _spriteIMG;
    [SerializeField]
    private GoToScene _sceneChangerScript;


    private void Start()
    {
        _spriteIMG = this.gameObject.GetComponent<Image>();
        _sceneChangerScript = this.gameObject.GetComponent<GoToScene>();
    }
    public void StartButtonAnim()
    {
        StartCoroutine(ButtonAnim());
    }
    IEnumerator ButtonAnim()
    {
        foreach (var sprite in Sprites)
        {
            Debug.Log(sprite.name);
            _spriteIMG.sprite = sprite;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.1f);
        //then go to the next scene
        _sceneChangerScript.LoadScene();
    }
}
