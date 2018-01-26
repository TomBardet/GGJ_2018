using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerVariables", menuName = "3C")]
public class PlayerVariables : ScriptableObject {

    public float speed;
    public float flapForce;
    public float turnSpeed;
    public float JoystickDeadZoneX;
        
}
