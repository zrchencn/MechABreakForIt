using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject currBuff;
    [SerializeField] private MechMovement _movement;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject obj = col.gameObject;
        currBuff = obj;

        if (currBuff.tag == "JumpBooster")
        {
            _movement.superJump();
        } else if (currBuff.tag == "SpeedBooster")
        {
            _movement.superSpeed();
        }

        currBuff.SetActive(false);

        StartCoroutine(reactivate(currBuff));
        // Destroy(col.gameObject);
    }

    // private void reactivate()
    // {
    //     currBuff.SetActive(true);
    // }

    IEnumerator reactivate(GameObject obj)
    {
        yield return new WaitForSeconds(3.0f);
        obj.SetActive(true);
    }

}