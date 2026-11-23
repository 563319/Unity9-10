using UnityEngine;
using UnityEngine.InputSystem;
//using UnityEngine.InputSystem.EnhancedTouch;

public class GyroScript : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true; //Enables the gyro functionality within unity
    }

    void Update()
    {
        Vector3 previousEulerAngles = transform.eulerAngles;
        //Vector3 gyroInput = -Input.gyro.rotationRateUnbiased; // invert android
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased; // ios no invert
        Vector3 targetEulerAngles = previousEulerAngles + gyroInput * Time.deltaTime * Mathf.Rad2Deg;
        targetEulerAngles.z = 0.0f; //LockZ rotation
        transform.eulerAngles = targetEulerAngles;
        /*
        //Trying to use new input system for touch input didn't work, so have to use the old input system below.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            print("Vibrating");
            Handheld.Vibrate();
        }
        */
    }
    
}
