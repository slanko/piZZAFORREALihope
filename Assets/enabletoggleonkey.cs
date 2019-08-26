using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabletoggleonkey : MonoBehaviour
{
    public KeyCode toggleButton;
    public GameObject itemToToggle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(toggleButton) == true)
        {
            if (itemToToggle.activeSelf == false)
            {
                itemToToggle.SetActive(true);
            }
            else
            {
                itemToToggle.SetActive(false);
            }
        }
    }
}
