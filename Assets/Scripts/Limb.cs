using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour
{
    [SerializeField] private int speed = 1300;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float angleLeft;
    [SerializeField] private float angleRight;

    [SerializeField] private float balanceForce;
    [SerializeField] private float balanceAngle;
    private State state;

    public enum State
    {
        IDLE,
        LEFT,
        RIGHT
    };

    // Start is called before the first frame update
    void Start()
    {
        state = State.IDLE;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.IDLE)
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, balanceAngle, balanceForce * Time.fixedDeltaTime));
        }
        else
        {
            if (state == State.LEFT)
            {
                rb.MoveRotation(Mathf.LerpAngle(rb.rotation, angleLeft, speed * Time.fixedDeltaTime));
            }
            else
            {
                rb.MoveRotation(Mathf.LerpAngle(rb.rotation, angleRight, speed * Time.fixedDeltaTime));
            }
        }
    }

    public void setState(State toSet)
    {
        state = toSet;
    }
}