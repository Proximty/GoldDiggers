using UnityEngine;
using UnityEngine.UI;
#if TMP_PRESENT
using TMPro;
#endif
using System.Collections;

[RequireComponent(typeof(RectTransform))]
public class SlideUpText : MonoBehaviour
{
    [Tooltip("Duration of the slide in seconds")]
    public float duration = 1.0f;

    [Tooltip("Vertical distance in pixels to move (positive = up)")]
    public float distance = 100f;

    [Tooltip("Optional delay before starting")]
    public float delay = 0f;

    [Tooltip("Easing curve (0..1 on x). Use preset for smooth ease in/out")]
    public AnimationCurve easing = AnimationCurve.EaseInOut(0, 0, 1, 1);

    // whether to start automatically on Awake/Start
    public bool playOnStart = true;

    private RectTransform rt;
    private Vector2 startPos;
    private Vector2 targetPos;

    [Header("turn of instructions")]
    [SerializeField] private GameObject _vergrootglas;
    [SerializeField] private GameObject _gameTuruorial;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
        targetPos = startPos + new Vector2(0, distance);
    }

    void Start()
    {
        if (playOnStart)
            Play();
        _vergrootglas.SetActive(false);
        _gameTuruorial.SetActive(false);
    }

    /// <summary>
    /// Start sliding the text up (restarts if already running).
    /// </summary>
    public void Play()
    {
        StopAllCoroutines();
        StartCoroutine(SlideRoutine());
    }
    /// <summary>
    /// Optional: public to reset position
    /// </summary>
    /// <param name="stopAnimation"></param>
    public void ResetPosition(bool stopAnimation = true)
    {
        if (stopAnimation) StopAllCoroutines();
        rt.anchoredPosition = startPos;
    }
    private IEnumerator SlideRoutine()
    {
        if (delay > 0f) yield return new WaitForSeconds(delay);

        float t = 0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float normalized = Mathf.Clamp01(t / duration);
            float e = easing.Evaluate(normalized);
            rt.anchoredPosition = Vector2.LerpUnclamped(startPos, targetPos, e);
            yield return null;
        }

        rt.anchoredPosition = targetPos;
    }

 
}



