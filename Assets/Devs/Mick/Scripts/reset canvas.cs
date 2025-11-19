using System.Collections;
using UnityEngine;

public class resetcanvas : MonoBehaviour
{
    //public float _NothingTimer;
    public GameObject Canvas;
    public float TimerDuration = 3f;
    void Update()
    {
        StartCoroutine(NothingTimer());
    }

    private IEnumerator NothingTimer()
    {
        yield return new WaitForSeconds(TimerDuration);
        Canvas.SetActive(true);
        TimerDuration = 10f; 
    }
}
