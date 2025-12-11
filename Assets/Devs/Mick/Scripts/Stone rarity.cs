using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Stonerarity : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private List<GameObject> prefabs = new List<GameObject>();
    [SerializeField] private List<GameObject> audio = new List<GameObject>();

    [SerializeField] public int index;
    
    [Header("Spawn Chances (groter is makkelijker te krijgen)")]
    [SerializeField] private List<float> chance = new List<float> {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f};

    [SerializeField] TextMeshProUGUI FossilText;
    public GameObject SelectedPrefab;

    void Start()
    {
        //it spawns the selected prefab in Start()
         SelectedPrefab = GetRandomPrefab();
        if (SelectedPrefab != null)
        {
            Instantiate(SelectedPrefab, transform.position, transform.rotation);
        }
        //give the tmp the selectedPrefab text
        SpawnGem GemScript= SelectedPrefab.GetComponent<SpawnGem>();
        if (GemScript != null)
        {
            FossilText.text = GemScript.FossilInfo;
        }
        else
        {
            FossilText.text = "No text about the fossil found!";
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
            //if (randomValue < chance[i])
            //    //num = i;
            //    return p;

            //randomValue -= chance[i];
            //i++;
            if (randomValue < chance[i])
            {
                index = i; // Save the index of the selected prefab
                return (p); // Return the prefab and its index as a tuple
            }

            randomValue -= chance[i];
            i++;
        }

        return null;
    }
}
