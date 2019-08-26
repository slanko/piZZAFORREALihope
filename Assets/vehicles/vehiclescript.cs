using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehiclescript : MonoBehaviour {
    public float initialMoveSpeed = 40;
    public float moveSpeed;
    public Vector3 startPos;
    // Use this for initialization
    void Start () {
        moveSpeed = initialMoveSpeed;
        startPos = transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y + Random.Range(-10, 10), transform.position.z);
        moveSpeed = moveSpeed + Random.Range(-10, 10);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "cleanup")
        {
            moveSpeed = initialMoveSpeed;
            transform.position = startPos;
            moveSpeed = moveSpeed + Random.Range(-10, 10);
        }

    }
}
