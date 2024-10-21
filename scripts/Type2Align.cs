using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type2Align : MonoBehaviour
{
    /*public GameObject target;

    private bool hasCollided = false;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cube.OnCollisionReference += () =>
        {
            hasCollided = true;
        };
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hasCollided)
        {
            Quaternion prevRot = rb.rotation;

            Vector3 directionDest = target.transform.position - transform.position;
      
            Quaternion targetRot = Quaternion.LookRotation(directionDest);

            // Then interpolate it
            Quaternion currentRotation = rb.rotation;

            GetComponent<Rigidbody>().rotation = Quaternion.Lerp(currentRotation, targetRot, 10f * Time.fixedDeltaTime);
            if (prevRot == rb.rotation)
            {
                hasCollided = false;
            }
            prevRot = rb.rotation;
        }
    }*/
}
