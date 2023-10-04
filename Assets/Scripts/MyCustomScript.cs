using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomScript : MonoBehaviour
{
    public KeyCode input;
    private float targetPressed;
    private float targetReleased;

    private HingeJoint hinge;
    public AudioManager audioManager;

    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetReleased = hinge.limits.min;

    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
        MovePaddle();
        InputSound();
    }

    public void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        // Read Input Here
        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            
            jointSpring.targetPosition = targetReleased;
        }

        hinge.spring = jointSpring;
    }

    public void InputSound()
    {
        if (Input.GetKeyDown(input))
        {
            audioManager.PlayRaiseHigeSound(this.gameObject.transform.position);
        }
        else if (Input.GetKeyUp(input))
        {
            audioManager.PlayReleaseHigeSound(this.gameObject.transform.position);
        }
    }
    private void MovePaddle()
    {
        // Move Paddle Here
    }
}
