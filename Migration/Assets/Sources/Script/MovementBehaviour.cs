using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {

    [SerializeField]
    PlayerVariables birdCaracteristics;
    
    public float joystick;

    Rigidbody playerRb;
	// Use this for initialization
	void Start ()
    {
        playerRb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        InputGetter();
        JoystickOrientation();

        joystick = Input.GetAxis("LeftJoystick X");
	}

    private void FixedUpdate()
    {
        MoveForward();

    }

    void InputGetter()
    {
        if (Input.GetButtonDown("Button A"))
        {
            FlappingWings();
        }
        
    }

    void JoystickOrientation()
    {
        MoveTranslate(Input.GetAxis("LeftJoystick X"));

        
    }

    void MoveForward()
    {
        playerRb.AddForce(transform.up * birdCaracteristics.speed, ForceMode.Impulse);
        Debug.DrawRay(transform.position, transform.up * birdCaracteristics.speed, Color.red);
    }

    void MoveTranslate(float joystickValue)
    {
       
        playerRb.AddTorque(transform.right * birdCaracteristics.turnSpeed * joystick, ForceMode.Force);
        playerRb.AddTorque(-transform.up * birdCaracteristics.turnSpeed* joystick);
    }

    void FlappingWings()
    {
        playerRb.AddForce(Vector3.up * birdCaracteristics.flapForce, ForceMode.Impulse);

    }
}
