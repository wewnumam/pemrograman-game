using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject kart;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - kart.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position + offset, kart.transform.position, 0.5f);
        transform.LookAt(kart.transform);
    }
}
