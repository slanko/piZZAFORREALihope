using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movescript : MonoBehaviour {

    public float lookspeed = 3;

    public float movespeed = 3;

    public float sprintspeed = 6;
	// FixedUpdate is called once per thingy
	void FixedUpdate () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * lookspeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;

        if(Input.GetKey(KeyCode.LeftShift) == true){
            movespeed = sprintspeed;
        }
        if (Input.GetKey(KeyCode.LeftShift) != true)
        {
            movespeed = 3;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //RESET SCRIPTO
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //EXIT SCRIPTO
            Application.Quit();
        }


        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
