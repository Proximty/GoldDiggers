using UnityEngine;

public class HelpFlicker : MonoBehaviour
{
    public Flicker Flicker;
    private float timer = 0f;
    private float flickerDelay = 300f; // 5 minutes
    
    void Start()
    {
        Flicker = GameObject.Find("Flicker").GetComponent<Flicker>();
    }

    public void StartFlicker()
    {
        // Count up
        timer += Time.deltaTime;

        // When timer reaches 5 minutes, trigger flicker and reset
        if (timer >= flickerDelay)
        {
            timer = 0f; // reset timer

            if (Flicker != null)
            {
                Flicker.flicker();
            }
            else
            {
                Debug.LogWarning("Flicker component not found.");
            }
        }
    }
}
