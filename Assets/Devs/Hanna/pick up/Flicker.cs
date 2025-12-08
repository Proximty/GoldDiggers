using UnityEngine;



public class Flicker : MonoBehaviour
{
    public Color glowColor = Color.yellow;

    [Header("Flicker Settings")]
    public float MinIntensity = 0f;
    public float MaxIntensity = 1.5f;
    public float FlickerSpeed = 2f;

    [Header("Overall Brightness")]
    public float EmissionStrength = 0.5f;

    private Renderer _Rend;
    private MaterialPropertyBlock _Mpb;
    private float _CurrentIntensity;

    void Start()
    {
        _Rend = GetComponent<Renderer>();
        _Mpb = new MaterialPropertyBlock();

        // --- CRITICAL ---  
        // Force the shader to ENABLE emission 
        if (_Rend.sharedMaterial != null)
        {
            _Rend.sharedMaterial.EnableKeyword("_EMISSION");

            // For URP Lit shaders, emission MUST be explicitly set once
            _Rend.sharedMaterial.SetColor("_EmissionColor", glowColor * 0.01f);
        }

        _CurrentIntensity = MaxIntensity;
    }
    private void Update()
    {
        flicker();
    }
    /// <summary>
    /// make the flicker happen and set emission on
    /// </summary>
    public void flicker()
    {
        float targetIntensity = Random.Range(MinIntensity, MaxIntensity);
        _CurrentIntensity = Mathf.Lerp(_CurrentIntensity, targetIntensity, FlickerSpeed * Time.deltaTime);

        _Rend.GetPropertyBlock(_Mpb);

        // final emissive value
        Color emissive = glowColor * _CurrentIntensity * EmissionStrength;

        // Apply color
        _Mpb.SetColor("_EmissionColor", emissive);
        _Rend.SetPropertyBlock(_Mpb);

        // --- CRITICAL PART ---
        // Disable emission keyword if emissive is zero
        if (emissive.maxColorComponent <= 0.0001f)
        {
            _Rend.sharedMaterial.DisableKeyword("_EMISSION");
        }
        else
        {
            _Rend.sharedMaterial.EnableKeyword("_EMISSION");
        }
    }

}


