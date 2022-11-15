using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LowerArm : MonoBehaviour
{
    [SerializeField] private int speed = 1300;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private KeyCode leftButton;
    [SerializeField] private KeyCode rightButton;
    [SerializeField] private float angles;
    [SerializeField] private bool rightArm;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (rightArm == true && Input.GetKey(leftButton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 180, 300 * Time.fixedDeltaTime));
        }
        else if (rightArm == true && Input.GetKey (rightButton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 0, 300 * Time.fixedDeltaTime));
        }
        else if (rightArm == true)
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 90, 300 * Time.fixedDeltaTime));
        }
        else if (rightArm == false && Input.GetKey(rightButton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 180, 300 * Time.fixedDeltaTime));
        }
        else if (rightArm == false && Input.GetKey (leftButton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 0, 300 * Time.fixedDeltaTime));
        }
        else
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 270, 300 * Time.fixedDeltaTime));
        }
    }
}
