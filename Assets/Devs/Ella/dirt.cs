using UnityEditor.SceneManagement;
using UnityEngine;

public interface IBrushable
{
    public void Brush();
}
public class dirt : MonoBehaviour, IBrushable
{
    [SerializeField] private GameObject _gem;
    [SerializeField] private GameObject _stoneInfo;
    [SerializeField] private int _stageDirt = 1;
    [SerializeField] public bool BrushActive = false;
    [SerializeField] private float _timer;
    [SerializeField] private GameObject _brushPrefab;

    /// <summary>
    /// Make The brush Brush things down
    /// </summary>
    /// 
    private void Update()
    {
        _timer += Time.deltaTime;
    }
    public void Brush()
    {
        if (BrushActive == true && _timer > 0.5f)
        {
            if (this.gameObject.activeSelf == true)
            {
                switch (_stageDirt)
                {
                    case 1:
                        SetTransfromOfRock(0.6f);
                        _stageDirt++;
                        break;
                    case 2:
                        SetTransfromOfRock(0.3f);
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
            Instantiate(_brushPrefab);
            _timer = 0f;
        }


        
    }

    public void BrushAwake(bool awake)
    {
        BrushActive = awake;
    }
    /// <summary>
    /// keeps track of the transform 
    /// </summary>
    /// <param name="size"></param>
    private void SetTransfromOfRock(float size)
    {
        this.gameObject.transform.localScale = new Vector3(size, size, size);

    }

    


}
