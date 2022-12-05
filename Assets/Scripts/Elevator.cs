using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float positionRadius;
    public LayerMask elevatorMask;
    public Transform playerPos;
    private bool isOnElevator;
    private Rigidbody2D elevator;
    private Rigidbody2D mech;
    [SerializeField] private float speed;
    [SerializeField] private Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isOnElevator = Physics2D.OverlapCircle(playerPos.position, positionRadius, elevatorMask);
        float step = speed * Time.deltaTime;
        if(isOnElevator)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
        }
    }
}
