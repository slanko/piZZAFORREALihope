using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randommaterials : MonoBehaviour
{
    public Material[] randomMaterials;
    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = randomMaterials[Random.Range(0, randomMaterials.Length - 1)];
    }
}
