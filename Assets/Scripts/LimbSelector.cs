using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbSelector : MonoBehaviour
{
    //public booleans that we can call elsewhere (i.e. MechMovement)
    public bool legSelected = true;
    public bool armSelected = false;
    private KeyCode upButton;
    private KeyCode downButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statement that sets which limb is selected
        if(Input.GetKey(upButton))
        {
            armSelected = true;
            legSelected = false;
        }
        else if(Input.GetKey(downButton))
        {
            legSelected = true;
            armSelected = false;
        }
    }
}
