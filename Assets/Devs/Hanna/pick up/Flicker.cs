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
   private void flicker()
   {
        float targetIntensity = Random.Range(minIntensity, maxIntensity);
        currentIntensity = Mathf.Lerp(currentIntensity, targetIntensity, flickerSpeed * Time.deltaTime);

        rend.GetPropertyBlock(mpb);

        // final emissive value
        Color emissive = glowColor * currentIntensity * emissionStrength;

        mpb.SetColor("_EmissionColor", emissive);

        rend.SetPropertyBlock(mpb);
   }
}


