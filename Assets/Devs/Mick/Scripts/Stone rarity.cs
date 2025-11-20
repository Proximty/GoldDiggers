using System.Collections.Generic;
using UnityEngine;

public class Stonerarity : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;
    public GameObject Prefab6;
    public GameObject Prefab7;
    public GameObject Prefab8;
    public GameObject Prefab9;
    public GameObject Prefab10;

    [Header("Spawn Chances (groter is makkelijker te krijgen)")]
    public float Chance1 = 1f;
    public float Chance2 = 1f;
    public float Chance3 = 1f;
    public float Chance4 = 1f;
    public float Chance5 = 1f;
    public float Chance6 = 1f;
    public float Chance7 = 1f;
    public float Chance8 = 1f;
    public float Chance9 = 1f;
    public float Chance10 = 1f;

    void Start()
    {
        GameObject selectedPrefab = GetRandomPrefab();
        if (selectedPrefab != null)
            Instantiate(selectedPrefab, transform.position, transform.rotation);
    }

    GameObject GetRandomPrefab()
    {
        GameObject[] prefabs =
        {
            Prefab1, Prefab2, Prefab3, Prefab4, Prefab5,
            Prefab6, Prefab7, Prefab8, Prefab9, Prefab10
        };

        float[] chances =
        {
            Chance1, Chance2, Chance3, Chance4, Chance5,
            Chance6, Chance7, Chance8, Chance9, Chance10
        };

        float totalChance = 0f;
        foreach (float c in chances)
            totalChance += c;

        float randomValue = Random.Range(0, totalChance);

        for (int i = 0; i < prefabs.Length; i++)
        {
            if (randomValue < chances[i])
                return prefabs[i];

            randomValue -= chances[i];
        }

        return null;
    }
}
