using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform currentPos;
    private Vector3 lastPlayerPos;
    [SerializeField] private bool isOnGround;
    [SerializeField] private bool dead;
    [SerializeField] private LayerMask ground;
    [SerializeField] private LayerMask deathbox;
    [SerializeField] private Transform topRightPos;
    [SerializeField] private Transform bottomLeftPos;
    [SerializeField] private float dropHeight;
    [SerializeField] private float minusX;
    // Start is called before the first frame update
    void Start()
    {
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        if(Physics2D.OverlapArea(topRightPos.position, bottomLeftPos.position, ground))
            {
            isOnGround = true;
        }
        else
        {
            isOnGround = false;
        }

        if (isOnGround)
        {
            lastPlayerPos = currentPos.position + new Vector3(horizontalInput - minusX, verticalInput + dropHeight, 0);
        }

        if (Physics2D.OverlapArea(topRightPos.position, bottomLeftPos.position, deathbox))
        {
            dead = true;
        }

        if (dead)
        {
            transform.position = lastPlayerPos;
            dead = false;
        }

       // Debug.Log("top right = " + topRightPos.position.ToString() + "bottom left =" + bottomLeftPos.position.ToString());

      /*  Debug.Log("dead = " + dead.ToString());
        Debug.Log("isOnGround = " + isOnGround.ToString());
         
      */
       // Debug.Log("lastPlayerPos = " + lastPlayerPos.ToString());
    }
}
