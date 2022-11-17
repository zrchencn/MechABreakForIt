using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limb : MonoBehaviour
{
    [SerializeField] private int speed = 1300;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float angles;
    [SerializeField] private float balanceForce;
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
        Debug.Log("state: " + state);
        if (state == State.IDLE)
        {
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, 0, balanceForce * Time.fixedDeltaTime));
        }
        else
        {
            float direction = state == State.LEFT ? -1f : 1f;
            rb.MoveRotation(Mathf.LerpAngle(rb.rotation, direction * angles, speed * Time.fixedDeltaTime));
        }
    }

    public void setState(State toSet)
    {
        state = toSet;
    }

}