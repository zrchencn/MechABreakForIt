using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Button : MonoBehaviour
{
    [SerializeField] private Rigidbody2D platform;
    [SerializeField] private LayerMask button;
    [SerializeField] private float speed;
    [SerializeField] private bool platformUp;
    [SerializeField] private bool platformDown;
    [SerializeField] private Transform hand1Top;
    [SerializeField] private Transform hand2Top;
    [SerializeField] private Transform hand1Bottom;
    [SerializeField] private Transform hand2Bottom;
    [SerializeField] private Transform destination;
    private Vector3 startPosition;
    private bool press;

    //[SerializeField] private Renderer gameObject;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.setColor("_Color", Color.red);
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (Physics2D.OverlapArea(hand1Top.position, hand1Bottom.position, button))
        {
            press = true;
            //transform.position = Vector3.MoveTowards(transform.position, destination.position, step
        }
        else if (Physics2D.OverlapArea(hand2Top.position, hand2Bottom.position, button))
        {
            press = true;
            //transform.position = Vector3.MoveTowards(transform.position, destination.position, step;
        }

        if (press==true)
        {
            movePlatform();
        }
    }

    void movePlatform()
    {
        float step = speed * Time.deltaTime;
      if (transform.position != destination.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination.position, step);
        }
      else if (transform.position == destination.position)
        {
            Task.Delay(3000);
            transform.position = startPosition;
            press = false;
        }
      //transform.position = Vector2.Lerp(transform.position, destination.position, Time.deltaTime);
    }
    

   /* IEnumerator move()
    {
        while (transform.position != destination.position)
        {
            Vector3.Lerp(transform.position, destination.position, speed);
            Debug.Log("go up");
            yield return null;
        }
    }
   */

}
