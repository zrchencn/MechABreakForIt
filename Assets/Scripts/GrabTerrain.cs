using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GrabTerrain : MonoBehaviour
{
    [SerializeField] private Transform leftHandTop;
    [SerializeField] private Transform rightHandTop;
    [SerializeField] private Transform leftHandBottom;
    [SerializeField] private Transform rightHandBottom;
    [SerializeField] private LayerMask ground;
    [SerializeField] private KeyCode p1GrabButton;
    [SerializeField] private KeyCode p2GrabButton;
    [SerializeField] private Transform leftHand;
    [SerializeField] private Transform rightHand;
    private bool rightGrab;
    private bool leftGrab;
	void Start()
    { 

	}

    void Update()
    {
        if (Input.GetKeyDown(p1GrabButton))
        {
            if (Physics2D.OverlapArea(leftHandTop.position, leftHandBottom.position, ground))
            { 
                leftGrab = true;
                Debug.Log("left grab");
            }
        }
        
        if (Input.GetKeyDown(p2GrabButton))
        {
            if(Physics2D.OverlapArea(rightHandTop.position, rightHandBottom.position, ground))
            { 
                rightGrab = true;
                Debug.Log("right grab");
            }
        }

        if (leftGrab)
        {
            if (Input.GetKeyUp(p1GrabButton))
            {
                leftGrab = false;
            }
            else
            {
                leftHand.position = new Vector3(leftHand.transform.position.x, leftHand.transform.position.y, 0);
            }
        }

        if (rightGrab)
        {
            if(Input.GetKeyUp(p2GrabButton))
            {
                rightGrab = false;
            }
            else
            {
                rightHand.position = new Vector3(rightHand.transform.position.x, rightHand.transform.position.y, 0);
            }
        }


    }

}
