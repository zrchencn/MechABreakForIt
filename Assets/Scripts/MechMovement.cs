using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechMovement : MonoBehaviour
{
    public string direction = null;
    //public float playerSpeed;

    [SerializeField] private Rigidbody2D mech;

    [SerializeField] private KeyCode p1LeftButton;
    [SerializeField] private KeyCode p1RightButton;
    [SerializeField] private KeyCode p2LeftButton;
    [SerializeField] private KeyCode p2RightButton;

    [SerializeField] private float thrust;
    [SerializeField] private int jumpMultiplier;
    [SerializeField] private float speedMultiplier;
    [SerializeField] private float jumpBuffDuration;
    [SerializeField] private float speedBuffDuration;
    
    private bool buffJump = false;
    private bool buffSpeed = false;
    private float OldThrust;
    


    // Start is called before the first frame update
    void Start()
    {
        OldThrust = thrust;
    }

    // Update is called once per frame
    void Update()
    {

        if (buffSpeed)
        {
            thrust = OldThrust * speedMultiplier;
        }
        else
        {
            thrust = OldThrust;
        }
        if (Input.GetKey(p1LeftButton) && Input.GetKey(p2LeftButton))
        {
            direction = "left";
            mech.AddForce(Vector2.left * thrust);
            //make the mech continue walking left
        }
        else if (Input.GetKey(p1RightButton) && Input.GetKey(p2RightButton))
        {
            direction = "right";
            mech.AddForce(Vector2.right * thrust);
            //make the mech continue walking right
        }

        if (buffJump)
        {
            handleJump(p1RightButton, p2LeftButton, new Vector2(0, 1), jumpMultiplier);
            handleJump(p1LeftButton, p2RightButton, new Vector2(0, 1), jumpMultiplier);
        }
    }

    private void handleJump(KeyCode button1, KeyCode button2, Vector2 direction, int multiplier)
    {
        if (Input.GetKey(button1) && Input.GetKeyUp(button2))
        {
            Debug.Log("ADDING FORCE");
            mech.AddForce(direction * multiplier);
        }
        else if (Input.GetKey(button2) && Input.GetKeyUp(button1))
        {
            Debug.Log("ADDING FORCE");
            mech.AddForce(direction * multiplier);
        }
    }

    public void superJump()
    {
        buffJump = true;
        Invoke("deactivateSuperJump", jumpBuffDuration);
    }
    
    public void superSpeed()
    {
        buffSpeed = true;
        Invoke("deactivateSuperSpeed", speedBuffDuration);
    }


    private void deactivateSuperJump()
    {
        buffJump = false;
    }
    
    private void deactivateSuperSpeed()
    {
        buffSpeed = false;
    }
}