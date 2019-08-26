using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwee : MonoBehaviour
{
    public GameObject thrownItem;
    public KeyCode throwButton;
    public Quaternion instantiatedRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(throwButton)){
            instantiatedRotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
            Object.Instantiate(thrownItem, transform.position, instantiatedRotation);
        }
    }
}
