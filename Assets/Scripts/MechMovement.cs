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

    [SerializeField] private float mass;
    private int count;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(p1LeftButton) && Input.GetKeyDown(p2LeftButton))
            {
                direction = "left";
                mech.AddForce(Vector2.left * mass);
            //make the mech continue walking left
            }
            else if (Input.GetKey(p1RightButton) && Input.GetKeyDown(p2RightButton))
            {
                direction = "right";
                mech.AddForce(Vector2.right * mass);
            //make the mech continue walking right
            }

        handleJump(p1RightButton, p2LeftButton, new Vector2(0, 1), "Jump top crossed!", 10);
        handleJump(p1LeftButton, p2RightButton, new Vector2(0, 1), "Jump top uncrossed!", 10);
        //handleJump(p2LeftButton, p1LeftButton, new Vector2(1, 1), "Jump to Right!", 10);
        //handleJump(p2RightButton, p1RightButton, new Vector2(-1, 1), "Jump to Left!", 10);


    }

    private void handleJump(KeyCode button1, KeyCode button2, Vector2 direction, string mesg, int multiplier)
    {
        if (Input.GetKey(button1) && Input.GetKeyUp(button2))
        {
            Debug.Log(mesg + count);
            count++;
            mech.AddForce(direction * mass * multiplier);
        }
        else if (Input.GetKey(button2) && Input.GetKeyUp(button1))
        {
            Debug.Log(mesg + count);
            count++;
            mech.AddForce(direction * mass * multiplier);
        }
    }
}
