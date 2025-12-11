using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Dit script is voor de ui van het breken en schoonmaken van de fossielen
/// </summary>
public class AxeNBrushUI : MonoBehaviour
{
    [Header("axe")]
    [SerializeField] private rock1 _rockScipt;
    [SerializeField] private GameObject _rockToBreak;
    [SerializeField] private Image _axeSprite;

    [Header("axe sprites")]
    [SerializeField] private Sprite _axeGREEN;
    [SerializeField] private Sprite _axeRED;
    [SerializeField] private Sprite _axeSELECTED;
    //-----------------------------------------------
    //-----------------------------------------------
    [Header("brush")]
    [SerializeField] private dirt _dirtScipt;
    [SerializeField] private GameObject _dirtToBrush;
    [SerializeField] private Image _brushSprite;

    [Header("brush sprites")]
    [SerializeField] private Sprite _brushGREEN;
    [SerializeField] private Sprite _brushRED;
    [SerializeField] private Sprite _brushSELECTED;




    private void Update()
    {
        //checkt of het steen er nogsteeds is
        if (_rockScipt != null)
        {
            //kijk of de axe geselcteerd is
            if (_rockScipt.ActiveAxe == true)
            {
                _axeSprite.sprite = _axeSELECTED;
            }
            //anders maak groen als niet maar wel gebruikt kan worden
            else if (_rockToBreak != null)
            {
                //show green
                _axeSprite.sprite = _axeGREEN;


            }
            else if (_rockToBreak == null)
            {
                //show red
                _axeSprite.sprite = _axeRED;
            }
        }
        //anders staat de ui rood
        else
        {
            _axeSprite.sprite = _axeRED;
        }
        //check f de dirt al verwijders is
        if (_dirtScipt != null)
        {
            //kijk of de brush geselecteerd is
            if (_dirtScipt.BrushActive == true)
            {
                _brushSprite.sprite = _brushSELECTED;
            }
            else if (_dirtToBrush != null)
            {
                //show green
                _brushSprite.sprite = _brushGREEN;

            }
            else if (_dirtToBrush == null)
            {
                //show red
                _brushSprite.sprite = _brushRED;
            }
        }
        else
        {
            _brushSprite.sprite = _brushRED;
        }
    }
}
