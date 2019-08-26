using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randombuildinglights : MonoBehaviour
{
    public float amountOfTime;
    public float timer = 0f;
    public Material[] randomMaterials;
    Renderer rend;
    public bool lightBool;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = randomMaterials[Random.Range(0, 2)];
        amountOfTime = Random.Range(10f, 300f);
        timer = Random.Range(0f, 95f);
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > amountOfTime)
        {
            timer = 0f;
            amountOfTime = Random.Range(10f, 300f);
            if (lightBool == true)
            {
                rend.material = randomMaterials[0];
                lightBool = false;
            }
            else
            {
                rend.material = randomMaterials[1];
                lightBool = true;
            }
        }

    }
}
