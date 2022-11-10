using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    [SerializeField] private int speed = 1300;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private KeyCode leftButton;
    [SerializeField] private KeyCode rightButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(leftButton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, -60, speed * Time.fixedDeltaTime));
            Debug.Log("MoveLeft" + rb.ToString());
        }
        else if (Input.GetKey(rightButton))
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 60, speed * Time.fixedDeltaTime));
            Debug.Log("MoveRight" + rb.ToString());
        }
        else
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 0, 300 * Time.fixedDeltaTime));
        }
    }
}