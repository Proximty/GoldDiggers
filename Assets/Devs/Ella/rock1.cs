using Unity.VisualScripting;
using UnityEngine;

public class rock1 : MonoBehaviour, IBreakable
{
    [SerializeField] private GameObject _dirt;
    [SerializeField] private int _stageRock = 1;
    [SerializeField] private GameObject _daROCK;
    [SerializeField] public bool ActiveAxe = false;
    [SerializeField] private GameObject _axePrefab;
    [SerializeField] private float _timer;

    /// <summary>
    /// this makes the rock breaks 
    /// </summary>
    /// 
    private void Update()
    {
        _timer += Time.deltaTime;
    }
    public void Break(int powerLevel)
    {
        if (ActiveAxe == true && _timer > 0.3f)
        {
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
            Vector3 _objTransform = this.gameObject.transform.position;
            this.gameObject.transform.position = new Vector3(_objTransform.x + 0.2f, _objTransform.y + 0.2f, _objTransform.z);

            //activate axe anim
            Instantiate(_axePrefab);
            _timer = 0f;
        }

    }

    public void AxeAwake(bool awake)
    {
        ActiveAxe = awake;
    }
    

    //fucntion to change the size of the rock and the y rotation
    private void SetTransfromOfRock(float size)
    {
        
        _daROCK.transform.localScale = new Vector3(size, size, size);
        //this.gameObject.transform.eulerAngles = new Vector3 (0, rotation, 0);
    }
}
