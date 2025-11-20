using Unity.VisualScripting;
using UnityEngine;

public class rock1 : MonoBehaviour, IBreakable
{
    /// <summary>
    /// Dit script is voor het breken van het steendoormiddel van touch input
    /// je moet op een bepaald cirkel klikken die zich verplaatst na elke stage rock
    /// de axe anim wordt hier ook geactiveerd bij het breken van het steen
    /// </summary>
    [SerializeField] private GameObject _dirt;
    [SerializeField] private int _stageRock = 1;
    [SerializeField] private GameObject _daROCK;
    [SerializeField] public bool ActiveAxe = false;
    [SerializeField] private GameObject _axePrefab;
    [SerializeField] private float _timer;
    private void Update()
    {
        _timer += Time.deltaTime;
    }
    //functie voor het breken van het steen
    public void Break(int powerLevel)
    {
        //kijk of de axe actie is en of de animatie al afgespeeld is van de axe doormiddel van timer
        if (ActiveAxe == true && _timer > 0.3f)
        {
            //check welke stage het steen is en shrink het afhankelijk daarvan
            switch (_stageRock)
            {
                case 1:
                    SetTransfromOfRock(1.6960754f);
                    _stageRock++;
                    break;
                case 2:
                    SetTransfromOfRock(1.1855062f);
                    _stageRock++;
                    break;
                case 3:
                    _dirt.SetActive(true);
                    Destroy(_daROCK);
                    break;
            }
            //verplaats de target van het steen
            Vector3 _objTransform = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(_objTransform.x + 0.2f, _objTransform.y + 0.2f, _objTransform.z);

            //activeer de axe anim
            Instantiate(_axePrefab);
            _timer = 0f;
        }

    }
    //bool voor het avtiveren en deactiveren van de axe
    public void AxeAwake(bool awake)
    {
        ActiveAxe = awake;
    }
    

    //functie om de maat van het steen aan te passen
    private void SetTransfromOfRock(float size)
    {
        _daROCK.transform.localScale = new Vector3(size, size, size);
    }
}
