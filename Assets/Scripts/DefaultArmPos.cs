using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DefaultArmPos : MonoBehaviour
{
    [SerializeField] private float angles;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, angles, 300 * Time.fixedDeltaTime));
    }
}
