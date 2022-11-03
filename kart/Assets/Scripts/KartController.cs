using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartController : MonoBehaviour
{
    public float speed;
    public float steeringWheelForce;

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < 1.25f)
        {
            if (Input.GetAxis("Vertical") > 0) {
                this.GetComponent<Rigidbody> ().velocity = this.transform.forward * speed;
                SteeringWheel(isBackward: false);
            }

            if (Input.GetAxis("Vertical") < 0) {
                this.GetComponent<Rigidbody> ().velocity = -this.transform.forward * (speed / 2);
                SteeringWheel(isBackward: true);
            } 
        }
    }

    void SteeringWheel(bool isBackward)
    {
        float reverseRotate = 1;
        if (isBackward) reverseRotate = -1;

        if (Input.GetAxis("Horizontal") > 0) {
            this.transform.RotateAround(
                this.transform.position, Vector3.up, steeringWheelForce * reverseRotate);
        }

        if (Input.GetAxis("Horizontal") < 0) {
            this.transform.RotateAround(
                this.transform.position, Vector3.up, -steeringWheelForce * reverseRotate);
        }
    }
}
