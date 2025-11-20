using UnityEditor.SceneManagement;
using UnityEngine;

public interface IBrushable
{
    public void Brush();
}
public class dirt : MonoBehaviour, IBrushable
{
    /// <summary>
    /// Dit script is voor het brushen van de stenen doormiddel van touch input
    /// het speelt ook de bruh anim af nadat er geklikt is op de dirt
    /// </summary>
    [SerializeField] private GameObject _gem;
    [SerializeField] private GameObject _stoneInfo;
    [SerializeField] private int _stageDirt = 1;
    [SerializeField] public bool BrushActive = false;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _brushPrefab;

    private void Update()
    {
        _timer += Time.deltaTime;
    }
    //functie voor het schoonmaken/brushen van stenen
    public void Brush()
    {
        //kijk of de brush actief is of de brush anim al afgespeeld is
        if (BrushActive == true && _timer > 0.5f)
        {
            //check of dit object aanstaat
            if (this.gameObject.activeSelf == true)
            {
                //afhankelijk van de stage van de dirt, maak de dirt kleiner
                switch (_stageDirt)
                {
                    case 1:
                        SetTransfromOfDirt(0.6f);
                        _stageDirt++;
                        break;
                    case 2:
                        SetTransfromOfDirt(0.3f);
                        _stageDirt++;
                        break;
                    case 3:
                        Debug.Log("U removed the dirt from the rock");
                        _gem.SetActive(true);
                        _stoneInfo.SetActive(true);
                        Destroy(this.gameObject);
                        break;
                }

            }
            //speel brush anim af
            Instantiate(_brushPrefab);
            _timer = 0f;
        }


        
    }
    //fucntie voor het activeren/deactiveren van de brush
    public void BrushAwake(bool awake)
    {
        BrushActive = awake;
    }
    //deze functie bepaalt de groote van de dirt
    private void SetTransfromOfDirt(float size)
    {
        this.gameObject.transform.localScale = new Vector3(size, size, size);

    }

    


}
