using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    [SerializeField] private KeyCode p1UpButton;
    [SerializeField] private KeyCode p2UpButton;

    private bool leftHandGrab;
    private bool rightHandGrab;
    public LimbSelector lS;

    // Start is called before the first frame update
    void Start()
    {
        leftHandGrab = false;
        rightHandGrab = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lS.p1LegSelected == false)
        {
            if (Input.GetKey(p1UpButton) && leftHandGrab == false)
            {
                leftHandGrab = true;
            }
            else if (leftHandGrab == true)
            {
                leftHandGrab = false;
                Destroy(GetComponent<FixedJoint2D>());
            }
        }

        if (lS.p2LegSelected == false)
        {
            if (Input.GetKey(p2UpButton) && rightHandGrab == false)
            {
                rightHandGrab = true;
            }
            else if (rightHandGrab == true)
            {
                rightHandGrab = false;
            }
        }

        if (rightHandGrab == true && lS.p2LegSelected == true)
        {
            rightHandGrab = false;
        }

        if (leftHandGrab == true && lS.p1LegSelected == true)
        {
            leftHandGrab = false;
        }

    }
    private void LeftCollisionEnter2D(Collision2D leftCol)
    {
        if (leftHandGrab)
        {
            Rigidbody2D mech = leftCol.transform.GetComponent<Rigidbody2D>();
            if (mech != null)
            {
                FixedJoint2D fj = transform.gameObject.AddComponent(typeof(FixedJoint2D)) as FixedJoint2D;
                fj.connectedBody = mech;
            }
            else
            {
                FixedJoint2D fj = transform.gameObject.AddComponent(typeof(FixedJoint2D)) as FixedJoint2D;
            }
        }
    }
    private void RightCollisionEnter2D(Collision2D rightCol)
    {
        if (rightHandGrab)
        {
            Rigidbody2D mech = rightCol.transform.GetComponent<Rigidbody2D>();
            if (mech != null)
            {
                FixedJoint2D fj = transform.gameObject.AddComponent(typeof(FixedJoint2D)) as FixedJoint2D;
                fj.connectedBody = mech;
            }
            else
            {
                FixedJoint2D fj = transform.gameObject.AddComponent(typeof(FixedJoint2D)) as FixedJoint2D;
            }
        }
    }
    /* private LayerMask interactable;
     public LimbSelector limbSelector;
     void Start()
     {

     }

     void Update()
     {
         if (limbSelector.p1LegSelected == false)
         {
             p1collisionCheck();
         }

         if (limbSelector.p2LegSelected == false)
         {
             p2collisionCheck();
         }    

     }*/
}
