using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRespawn : MonoBehaviour
{
    [SerializeField] private Transform currentPos;
    [SerializeField] private LayerMask deathbox1;
    [SerializeField] private LayerMask deathbox2;
    [SerializeField] private LayerMask deathbox3;
    [SerializeField] private Transform topRightPos;
    [SerializeField] private Transform bottomLeftPos;
    [SerializeField] private Transform spawnPoint1;
    [SerializeField] private Transform spawnPoint2;
    [SerializeField] private Transform spawnPoint3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapArea(topRightPos.position, bottomLeftPos.position, deathbox1))
        {
            currentPos.transform.position = spawnPoint1.position;
        }
        else if (Physics2D.OverlapArea(topRightPos.position, bottomLeftPos.position, deathbox2))
        {
            currentPos.transform.position = spawnPoint2.position;
        }
        else if (Physics2D.OverlapArea(topRightPos.position, bottomLeftPos.position, deathbox3))
        {
            currentPos.transform.position = spawnPoint3.position;
        }
    }
}
