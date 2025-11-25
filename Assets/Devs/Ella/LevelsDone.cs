using UnityEngine;

public class LevelsDone : MonoBehaviour
{
    public int LevelDoneInt = 0;
    [SerializeField] private GameObject _lvl2UNLOCKED;
    [SerializeField] private GameObject _lvl2LOCKED;
    [SerializeField] private GameObject _lvl3UNLOCKED;
    [SerializeField] private GameObject _lvl3LOCKED;
    

    private void Update()
    {
        //if level done = 0
        //only show 1
        //if level done = 1
        //show 2
        //if level done = 2
        //show 3

        switch (LevelDoneInt)
        {
            case 0:
                _lvl2LOCKED.SetActive(true);
                _lvl2UNLOCKED.SetActive(false);
                _lvl3LOCKED.SetActive(true);
                _lvl3UNLOCKED.SetActive(false);
                break;
            case 1:
                _lvl2LOCKED.SetActive(false);
                _lvl2UNLOCKED.SetActive(true);
                _lvl3LOCKED.SetActive(true);
                _lvl3UNLOCKED.SetActive(false);
                break;
            case 2:
                _lvl2LOCKED.SetActive(false);
                _lvl2UNLOCKED.SetActive(true);
                _lvl3LOCKED.SetActive(false);
                _lvl3UNLOCKED.SetActive(true);
                break;
        }
    }
}
