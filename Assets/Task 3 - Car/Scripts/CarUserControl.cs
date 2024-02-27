using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        float gravity = 0.0f;
        float sensitivity = 0.1f;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            //gravityX and gravityY 
            gravity = ((1.0f - sensitivity) * gravity) + (sensitivity * Input.acceleration.x);

            float handbrake = Input.GetAxis("Jump");
            m_Car.Move(gravity, -Input.acceleration.y, 0,0);
        }
    }
}
