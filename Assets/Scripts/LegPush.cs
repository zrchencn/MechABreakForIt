using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LegPush : MonoBehaviour
{
    private bool isOnGround;
    [SerializeField] private KeyCode p1LeftButton;
    [SerializeField] private KeyCode p2LeftButton;
    [SerializeField] private KeyCode p1RightButton;
    [SerializeField] private KeyCode p2RightButton;
    [SerializeField] private Rigidbody2D mech;
    [SerializeField] private float thrust;
    public bool p1LegSelected;
    public bool p2LegSelected;
    public float positionRadius;
    public LayerMask ground;
    public Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics2D.OverlapCircle(playerPos.position, positionRadius, ground);
        if (p1LegSelected)
        {
            if (isOnGround == true && Input.GetKeyUp(p1LeftButton))
            {
                mech.AddForce(Vector2.left * thrust);
            }
            else if (isOnGround == true && Input.GetKeyUp(p1RightButton))
            {
                mech.AddForce(Vector2.right * thrust);
            }
        }

        if (p2LegSelected)
        {
            if (isOnGround == true && Input.GetKeyUp(p2LeftButton))
            {
                mech.AddForce(Vector2.left * thrust);
            }

            else if (isOnGround == true && Input.GetKeyUp(p2RightButton))
            {
                mech.AddForce(Vector2.right * thrust);
            }
        }
    }
}
