using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomvehicle : MonoBehaviour {
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
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cleanup")
        {
            rend.material = randomMaterials[Random.Range(0, randomMaterials.Length)];
        }

    }
}
