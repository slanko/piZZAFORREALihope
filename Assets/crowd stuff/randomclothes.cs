using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomclothes : MonoBehaviour {
    public Material[] randomMaterials;
    Renderer rend;
    // Use this for initialization
    void Awake () {
        rend = GetComponent<Renderer>();
    }
    private void Start()
    {
        rend.material = randomMaterials[Random.Range(0, randomMaterials.Length)];
    }
}
