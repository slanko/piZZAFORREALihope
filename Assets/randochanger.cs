using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randochanger : MonoBehaviour
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
        arrayPosition = Random.Range(0, sequence.Length);
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
                arrayPosition = Random.Range(0, sequence.Length);
            }
        }

    }
}