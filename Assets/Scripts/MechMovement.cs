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
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKey(p1LeftButton) && Input.GetKey(p2LeftButton))
            {
                direction = "left";
                mech.AddForce(Vector2.left * mass);
            //make the mech continue walking left
            }
            else if (Input.GetKey(p1RightButton) && Input.GetKey(p2RightButton))
            {
                direction = "right";
                mech.AddForce(Vector2.right * mass);
            //make the mech continue walking right
            }
        
    }
}
