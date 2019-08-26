using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowdAI : MonoBehaviour {
    public int randomMin = -50;
    public int randomMax = 50;
    public int randomAmount;
    public float ySpin;
    public float rotateSpeed;
    public float moveSpeed;
    public float sizeDiff;
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        anim.speed = Random.Range(0.5f, 1.5f);
        sizeDiff = Random.Range(-0.1f, 0.1f);
        ySpin = transform.position.y;
        moveSpeed = Random.Range(1, 3);
        transform.localScale = new Vector3(transform.localScale.x + sizeDiff, transform.localScale.y + sizeDiff, transform.localScale.z + sizeDiff);

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        randomAmount = Random.Range(randomMin, randomMax);
        ySpin = ySpin + randomAmount;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, ySpin, 0), rotateSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
