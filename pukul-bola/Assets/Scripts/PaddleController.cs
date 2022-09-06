using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField]
        private float speed;
    [SerializeField]
        private string axis;
    [SerializeField]
        private float borderTop;
    [SerializeField]
        private float borderBottom;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementY = Input.GetAxis(axis) * speed * Time.deltaTime;

        float nextPosition = transform.position.y + movementY;
        
        if (nextPosition > borderTop) {
            movementY = 0;
        }
        
        if (nextPosition < borderBottom)
        {
            movementY = 0;
        }

        transform.Translate(0, movementY, 0);
    }
}
