using UnityEngine;

public interface IBrushable
{
    public void Brush(int Plevel);
}
public class dirt : MonoBehaviour, IBrushable
{
    /// <summary>
    /// Dit script is voor het brushen van de stenen doormiddel van touch input
    /// het speelt ook de bruh anim af nadat er geklikt is op de dirt
    /// </summary>
    [SerializeField] private GameObject _gem;
    //[SerializeField] private Stonerarity _stonteScipt;
    //public GameObject _stoneInfo;
    [SerializeField] private int _stageDirt = 1;
    [SerializeField] public bool BrushActive = false;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _brushPrefab;
    [SerializeField] private AudioSource _brushSound;
    [SerializeField] private AudioSource _MagicSound;


    [Header("dirt")]
    [SerializeField] private GameObject _dirt3;
    [SerializeField] private GameObject _dirt2;
    [SerializeField] private GameObject _dirt1;
   
    private void Update()
    {
        _timer += Time.deltaTime;
        
    }
    //functie voor het schoonmaken/brushen van stenen
    public void Brush(int Plevel)
    {
        
        int stagesToProcess = Mathf.Clamp(Plevel / 2, 1, 3);
        //kijk of de brush actief is of de brush anim al afgespeeld is
        //for (int stage = 1; stage <= stagesToProcess; stage++)
        if (BrushActive != false && _timer > 1f)
        {
            //check of dit object aanstaat
            if (this.gameObject.activeSelf == true)
            {
                //afhankelijk van de stage van de dirt, maak de dirt kleiner
                switch (_stageDirt)
                {
                    case 1:
                        
                        _dirt3.SetActive(false);
                        _dirt2.SetActive(true);
                        _stageDirt++;
                        BrushSound();
                        break;
                    case 2:
                        _dirt2.SetActive(false);
                        _dirt1.SetActive(true);
                        _stageDirt++;
                        BrushSound();


                        break;
                    case 3:
                        Debug.Log("U removed the dirt from the rock");
                        //_gem.SetActive(true);
                        Destroy(this.gameObject);
                        BrushSound();
                        MagicSound();
                        
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
    private void BrushSound()
    {
        _brushSound.Play();
    }

    private void MagicSound()
    {
        _MagicSound.Play();
    }
   
    //deze functie bepaalt de groote van de dirt
    //private void SetTransfromOfDirt(float size)
    //{
    //    this.gameObject.transform.localScale = new Vector3(size, size, size);

    //}




}
