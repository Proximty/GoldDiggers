using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class FossilManager : MonoBehaviour
{
    [Header("lists")]
    public List<GameObject> DugUpRocks = new List<GameObject>();
    public List<string> NameOfRocks = new List<string>();
    public List<GameObject> FossilPrefabs = new List<GameObject>();

    [Header("for fossil collecting")]
    [SerializeField] private string _sceneName;
    [SerializeField] private bool _fossilAdded = false;
    [SerializeField] private GameObject _gemObj;
    [SerializeField] private Stonerarity _gemScipt;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        _sceneName = SceneManager.GetActiveScene().name;
        if ((_sceneName == "fossils" || _sceneName == "rocks" ) )
        {
            _gemObj = GameObject.Find("gem");
            _gemScipt = _gemObj.GetComponent<Stonerarity>();

            if (_fossilAdded == false && _gemObj.activeInHierarchy)
            {
                //get the prefab of fossil from gem script
                FossilPrefabs.Add(_gemScipt.SelectedPrefab);
                _fossilAdded = true;
            }
        }
        else
        {
            _fossilAdded = false;
        }
    }

}
