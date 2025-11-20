using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stonerarity : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private List<GameObject> prefabs = new List<GameObject>();
    
    [Header("Spawn Chances (groter is makkelijker te krijgen)")]
    [SerializeField] private List<float> chance = new List<float> {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f};
    

    void Start()
    {
        //it spawns the selected prefab in Start()
        GameObject selectedPrefab = GetRandomPrefab();
        if (selectedPrefab != null)
        {
            Instantiate(selectedPrefab, transform.position, transform.rotation);
        }
    }

    GameObject GetRandomPrefab()
    {
        
        float totalChance = 0f;

        //calculate the weight of chance
        //If you have 10 items each with weight 1, totalChance = 10.
        foreach (float c  in chance)
        {
            totalChance += c;
        }

        //It picks a random number between 0 and totalChance
        float randomValue = Random.Range(0f, totalChance);

        int i = 0;
        //It loops through prefabs and determines which one the random value falls into
        foreach (GameObject p in prefabs)
        {
            if (randomValue < chance[i])
                return p;

            randomValue -= chance[i];
            i++;
        }

        return null;
    }
}
