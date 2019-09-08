using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class crowdAI : MonoBehaviour
{
    public int randomMin = -50, randomMax = 50, randomAmount;
    public float ySpin, rotateSpeed, moveSpeed, sizeDiff, dtd, distThreshold;
    Animator anim;
    NavMeshAgent nav;
    AudioSource aaudio;
    public bool wandering = true;
    GameObject chosenDestination, theAlmighty;
    godScript godbrain;

    // Use this for initialization
    void Start()
    {
        theAlmighty = GameObject.Find("GOD");
        godbrain = theAlmighty.GetComponent<godScript>();
        aaudio = GetComponent<AudioSource>();
        nav = GetComponent<NavMeshAgent>();
        anim = gameObject.GetComponent<Animator>();
        anim.speed = Random.Range(0.5f, 1.5f);
        sizeDiff = Random.Range(-0.1f, 0.1f);
        ySpin = transform.position.y;
        moveSpeed = Random.Range(1, 3);
        transform.localScale = new Vector3(transform.localScale.x + sizeDiff, transform.localScale.y + sizeDiff, transform.localScale.z + sizeDiff);
        chooseAnotherDestination();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (wandering == true)
        {
            randomAmount = Random.Range(randomMin, randomMax);
            ySpin = ySpin + randomAmount;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, ySpin, 0), rotateSpeed);
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        else
        {
            if (dtd < distThreshold)
            {
                wandering = true;
                Invoke("chooseAnotherDestination", Random.Range(5, 60));
            }
            if (chosenDestination != null)
            {
                dtd = Vector3.Distance(chosenDestination.transform.position, transform.position);
            }
        }
    }

    void chooseAnotherDestination()
    {
        wandering = false;
        chosenDestination = godbrain.destinations[Random.Range(0, godbrain.destinations.Length)];
        nav.SetDestination(chosenDestination.transform.position);
        aaudio.Play();
    }
}
