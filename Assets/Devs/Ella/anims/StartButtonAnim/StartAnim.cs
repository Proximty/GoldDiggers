using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class StartAnim : MonoBehaviour
{
    /// <summary>
    /// Script for starting the start button anim using a ienumerator
    /// </summary>
    //loop through a list and play each frame after x sec 
    [SerializeField] private List<Sprite> Sprites = new List<Sprite>();
    private Image _spriteIMG;
    [SerializeField]
    private GoToScene _sceneChangerScript;
    [SerializeField] private float timer;

    //haal de img die veranders moet worden inclusief het scene veranderen script
    private void Start()
    {
        _spriteIMG = this.gameObject.GetComponent<Image>();
        _sceneChangerScript = this.gameObject.GetComponent<GoToScene>();
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    public void StartButtonAnim()
    {
        //begin de animatie 
        if (timer > 2f)
        {
            timer = 0f;
            StartCoroutine(ButtonAnim());
        }
    }
    IEnumerator ButtonAnim()
    {
        //loop door elke sprite in de list
        foreach (var sprite in Sprites)
        {
            _spriteIMG.sprite = sprite;
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.1f);
        //then go to the next scene
        _sceneChangerScript.LoadScene();
    }
}
