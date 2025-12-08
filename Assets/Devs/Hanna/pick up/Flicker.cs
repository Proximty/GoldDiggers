using UnityEngine;



public class Flicker : MonoBehaviour
{
    public Color glowColor = Color.yellow;

    [Header("Flicker Settings")]
    public float minIntensity = 0f;
    public float maxIntensity = 1.5f;
    public float flickerSpeed = 2f;

    [Header("Overall Brightness")]
    public float emissionStrength = 0.5f;

    private Renderer rend;
    private MaterialPropertyBlock mpb;
    private float currentIntensity;

    void Start()
    {
        rend = GetComponent<Renderer>();
        mpb = new MaterialPropertyBlock();

        // --- CRITICAL ---  
        // Force the shader to ENABLE emission 
        if (rend.sharedMaterial != null)
        {
            rend.sharedMaterial.EnableKeyword("_EMISSION");

            // For URP Lit shaders, emission MUST be explicitly set once
            rend.sharedMaterial.SetColor("_EmissionColor", glowColor * 0.01f);
        }

        currentIntensity = maxIntensity;
    }
    private void Update()
    {
        flicker();
    }
    public void flicker()
    {
        float targetIntensity = Random.Range(minIntensity, maxIntensity);
        currentIntensity = Mathf.Lerp(currentIntensity, targetIntensity, flickerSpeed * Time.deltaTime);

        rend.GetPropertyBlock(mpb);

        // final emissive value
        Color emissive = glowColor * currentIntensity * emissionStrength;

        // Apply color
        mpb.SetColor("_EmissionColor", emissive);
        rend.SetPropertyBlock(mpb);

        // --- CRITICAL PART ---
        // Disable emission keyword if emissive is zero
        if (emissive.maxColorComponent <= 0.0001f)
        {
            rend.sharedMaterial.DisableKeyword("_EMISSION");
        }
        else
        {
            rend.sharedMaterial.EnableKeyword("_EMISSION");
        }
    }

}


