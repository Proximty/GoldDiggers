using UnityEngine;

public class Flicker : MonoBehaviour
{
    public Color glowColor = Color.yellow;

    [Header("Fade Settings")]
    public float minIntensity = 0f;
    public float maxIntensity = 0.5f;  // lower than before for dimmer glow
    public float fadeSpeed = 2f;

    [Header("Overall Brightness")]
    public float emissionStrength = 0.2f; // reduce overall brightness

    private Renderer rend;
    private MaterialPropertyBlock mpb;

    void Start()
    {
        rend = GetComponent<Renderer>();
        mpb = new MaterialPropertyBlock();

        var mat = rend.material;
        if (mat != null)
        {
            mat.EnableKeyword("_EMISSION");
            mat.SetColor("_EmissionColor", glowColor * 0.01f); // tiny initial value
        }
    }

    void Update()
    {
        FadeEmission();
    }
    /// <summary>
    /// makes it fade in and out 
    /// </summary>
    private void FadeEmission()
    {
        float lerpValue = (Mathf.Sin(Time.time * fadeSpeed) + 1f) / 2f;
        float intensity = Mathf.Lerp(minIntensity, maxIntensity, lerpValue);

        rend.GetPropertyBlock(mpb);
        mpb.SetColor("_EmissionColor", glowColor * intensity * emissionStrength);
        rend.SetPropertyBlock(mpb);
    }
}





