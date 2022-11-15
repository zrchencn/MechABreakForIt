using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbSelector : MonoBehaviour
{
    [SerializeField] private KeyCode p1UpButton;
    [SerializeField] private KeyCode p1DownButton;
    [SerializeField] private KeyCode p2UpButton;
    [SerializeField] private KeyCode p2DownButton;
    [SerializeField] private string p1Limb = null;
    [SerializeField] private string p2Limb = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(p1UpButton))
        {
            //disable Left Leg script
            GameObject.Find("LLeg1").GetComponent<Leg>().enabled = false;
            //enable Left Arm scripts
            GameObject.Find("LArm1").GetComponent<Arm>().enabled = true;
            GameObject.Find("LArm2").GetComponent<LowerArm>().enabled = true;
            //disable Left Default Arm scripts
            GameObject.Find("LArm1").GetComponent<DefaultArmPos>().enabled = false;
            GameObject.Find("LArm2").GetComponent<DefaultArmPos>().enabled = false;
            p1Limb = "arm";
        }
        else if (Input.GetKey(p1DownButton))
        {
            //disable Left Arm scripts
            GameObject.Find("LArm1").GetComponent<Arm>().enabled = false;
            GameObject.Find("LArm2").GetComponent<LowerArm>().enabled = false;
            //enable Left Default Arm scripts
            GameObject.Find("LArm1").GetComponent<DefaultArmPos>().enabled = true;
            GameObject.Find("LArm2").GetComponent<DefaultArmPos>().enabled = true;
            //enable Left Leg script
            GameObject.Find("LLeg1").GetComponent<Leg>().enabled = true;
            p1Limb = "leg";
        }
        else if (Input.GetKey(p2UpButton))
        {
            //disable Right Leg script
            GameObject.Find("RLeg1").GetComponent<Leg>().enabled = false;
            //enable Right Arm scripts
            GameObject.Find("RArm1").GetComponent<Arm>().enabled = true;
            GameObject.Find("RArm2").GetComponent<LowerArm>().enabled = true;
            //disable Right Default Arm script
            GameObject.Find("RArm1").GetComponent<DefaultArmPos>().enabled = false;
            GameObject.Find("RArm2").GetComponent<DefaultArmPos>().enabled = false;
            p2Limb = "arm";
        }
        else if (Input.GetKey(p2DownButton))
        {
            //disable Right Arm scripts
            GameObject.Find("RArm1").GetComponent<Arm>().enabled = false;
            GameObject.Find("RArm2").GetComponent<LowerArm>().enabled = false;
            //enable Right Default Arm script
            GameObject.Find("RArm1").GetComponent<DefaultArmPos>().enabled = true;
            GameObject.Find("RArm2").GetComponent<DefaultArmPos>().enabled = true;
            //enable Right Leg script
            GameObject.Find("RLeg1").GetComponent<Leg>().enabled = true;
            p2Limb = "leg";
        }
    }
}
