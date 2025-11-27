using UnityEngine;

public class LevelsDone : MonoBehaviour
{
    public int LevelDoneInt = 0;
    [SerializeField] private GameObject _lvl2UNLOCKED;
    [SerializeField] private GameObject _lvl2LOCKED;
    [SerializeField] private GameObject _lvl3UNLOCKED;
    [SerializeField] private GameObject _lvl3LOCKED;
    [SerializeField] private GameObject _lvl4UNLOCKED;
    [SerializeField] private GameObject _lvl4LOCKED;
    [SerializeField] private GameObject _lvl5UNLOCKED;
    [SerializeField] private GameObject _lvl5LOCKED;
    

    private void Update()
    {
        

        switch (LevelDoneInt)
        {
            case 0:
                lvlLocked(_lvl2LOCKED, _lvl2UNLOCKED);
                lvlLocked(_lvl3LOCKED, _lvl3UNLOCKED);
                lvlLocked(_lvl4LOCKED, _lvl4UNLOCKED);
                lvlLocked(_lvl5LOCKED, _lvl5UNLOCKED);
                break;
            case 1:
                lvlUnlocked(_lvl2LOCKED, _lvl2UNLOCKED);
                lvlLocked(_lvl3LOCKED, _lvl3UNLOCKED);
                lvlLocked(_lvl4LOCKED, _lvl4UNLOCKED);
                lvlLocked(_lvl5LOCKED, _lvl5UNLOCKED);
                break;
            case 2:
                lvlUnlocked(_lvl2LOCKED, _lvl2UNLOCKED);
                lvlUnlocked(_lvl3LOCKED, _lvl3UNLOCKED);
                lvlLocked(_lvl4LOCKED, _lvl4UNLOCKED);
                lvlLocked(_lvl5LOCKED, _lvl5UNLOCKED);
                break;
            case 3:
                lvlUnlocked(_lvl2LOCKED, _lvl2UNLOCKED);
                lvlUnlocked(_lvl3LOCKED, _lvl3UNLOCKED);
                lvlUnlocked(_lvl4LOCKED, _lvl4UNLOCKED);
                lvlLocked(_lvl5LOCKED, _lvl5UNLOCKED);
                break;
            case 4:
                lvlUnlocked(_lvl2LOCKED, _lvl2UNLOCKED);
                lvlUnlocked(_lvl3LOCKED, _lvl3UNLOCKED);
                lvlUnlocked(_lvl4LOCKED, _lvl4UNLOCKED);
                lvlUnlocked(_lvl5LOCKED, _lvl5UNLOCKED);

                break;
        }
    }


    private void lvlLocked(GameObject locked, GameObject unlocked)
    {
        locked.SetActive(true);
        unlocked.SetActive(false);
    }

    private void lvlUnlocked(GameObject locked, GameObject unlocked)
    {
        locked.SetActive(false);
        unlocked.SetActive(true);
    }
    
}
