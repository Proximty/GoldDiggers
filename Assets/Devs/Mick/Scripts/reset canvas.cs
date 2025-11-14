using System.Collections;
using UnityEngine;

public class resetcanvas : MonoBehaviour
{
    //public float _NothingTimer;
    public GameObject _canvas;
    public float _timerDuration = 3f;
    void Update()
    {
        StartCoroutine(NothingTimer());
    }

    private IEnumerator NothingTimer()
    {
        yield return new WaitForSeconds(_timerDuration);
        _canvas.SetActive(true);
    }
}
