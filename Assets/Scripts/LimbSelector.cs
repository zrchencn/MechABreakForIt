using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LimbSelector : MonoBehaviour
{
    [SerializeField] private KeyCode p1UpButton;
    [SerializeField] private KeyCode p1DownButton;
    [SerializeField] private KeyCode p1LeftButton;
    [SerializeField] private KeyCode p1RightButton;
    [SerializeField] private KeyCode p2UpButton;
    [SerializeField] private KeyCode p2DownButton;
    [SerializeField] private KeyCode p2LeftButton;
    [SerializeField] private KeyCode p2RightButton;
    [SerializeField] public Limb leg1;
    [SerializeField] public Limb leg2;
    [SerializeField] public Limb arm1;
    [SerializeField] public Limb arm2;
    [SerializeField] public Limb forearm1;
    [SerializeField] public Limb forearm2;
    [SerializeField] public Limb hand1;
    [SerializeField] public Limb hand2;
    public bool p1LegSelected;
    public bool p2LegSelected;

    // Start is called before the first frame update
    void Start()
    {
        p1LegSelected = true;
        p2LegSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(p1DownButton))
        {
            if (p1LegSelected)
            {
                leg1.setState(Limb.State.IDLE);
            }
            else
            {
                arm1.setState(Limb.State.IDLE);
            }

            p1LegSelected = !p1LegSelected;
        }

        if (Input.GetKeyDown(p2DownButton))
        {
            if (p2LegSelected)
            {
                leg2.setState(Limb.State.IDLE);
            }
            else
            {
                arm2.setState(Limb.State.IDLE);
            }

            p2LegSelected = !p2LegSelected;
        }

        handlePlayerControl(p1LeftButton, p1RightButton, p1LegSelected, leg1, arm1, forearm1, hand1);
        handlePlayerControl(p2LeftButton, p2RightButton, p2LegSelected, leg2, arm2, forearm2, hand2);

        if (transform.position.y < -10f)
        {
            Debug.Log("RESET");
            SceneManager.LoadScene("Scenes/SampleScene");
        }

    }


    private void handlePlayerControl(KeyCode leftButton, KeyCode rightButton, bool legSelected, Limb leg, Limb arm,
        Limb forearm, Limb hand)
    {
        if (Input.GetKey(leftButton))
        {
            if (legSelected)
            {
                leg.setState(Limb.State.LEFT);
            }
            else
            {
                arm.setState(Limb.State.LEFT);
                forearm.setState(Limb.State.LEFT);
                hand.setState(Limb.State.LEFT);
            }
        }
        else if (Input.GetKey(rightButton))
        {
            if (legSelected)
            {
                leg.setState(Limb.State.RIGHT);
            }
            else
            {
                arm.setState(Limb.State.RIGHT);
                forearm.setState(Limb.State.RIGHT);
                hand.setState(Limb.State.RIGHT);
            }
        }
        else
        {
            leg.setState(Limb.State.IDLE);
            arm.setState(Limb.State.IDLE);
            forearm.setState(Limb.State.IDLE);
            hand.setState(Limb.State.IDLE);
        }
    }
}