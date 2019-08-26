using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neonchanger : MonoBehaviour
{
    public float amountOfTime;
    public float timer = 0f;
    public Material[] sequence;
    Renderer rend;
    public int arrayPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > amountOfTime)
        {
            timer = 0f;
            if (arrayPosition < sequence.Length)
            {
                rend.material = sequence[arrayPosition];
                arrayPosition = arrayPosition + 1;
            }
            if(arrayPosition >= sequence.Length)
            {
                arrayPosition = 0;
            }
        }

    }
}