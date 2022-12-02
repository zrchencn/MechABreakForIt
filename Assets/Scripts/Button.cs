using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Rigidbody2D platform;
    [SerializeField] private LayerMask button;
    [SerializeField] private float upForce;
    [SerializeField] private bool platformUp;
    [SerializeField] private bool platformDown;
    [SerializeField] private Transform hand1Top;
    [SerializeField] private Transform hand2Top;
    [SerializeField] private Transform hand1Bottom;
    [SerializeField] private Transform hand2Bottom;
    [SerializeField] private Transform destination;

    //[SerializeField] private Renderer gameObject;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.setColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapArea(hand1Top.position, hand1Bottom.position, button))
        {
            movePlatform();
        }
        else if (Physics2D.OverlapArea(hand2Top.position, hand2Bottom.position, button))
        {
            movePlatform();
        }
    }

    void movePlatform()
    {
      if (platformUp)
        {
            platform.AddForce(transform.up * upForce, ForceMode2D.Impulse);
        }
        else if (platformDown)
        {
            platform.AddForce(-transform.up * upForce);
        }
      
      //transform.position = Vector2.Lerp(transform.position, destination.position, Time.deltaTime);
    }
}
