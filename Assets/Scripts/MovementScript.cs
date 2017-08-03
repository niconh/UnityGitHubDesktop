using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    [Header("Type of Control")]
    public bool press;
    public bool tap;

    [Header("Propierties")]
    public float vSpeed = 2f;
    public bool scale;
    public float scaleFactor = 1f;
    public float scaleMax = 1f;

    //[Header("Vertical Boundaries")]
    //public GameObject topBound;
    //public GameObject bottomBound;

    [HideInInspector]
    public bool pressed;
    [HideInInspector]
    public bool tapped;

    private float vDistance;
    //private Rigidbody rb;

	//void Start ()
 //   {
 //       //rb = GetComponent<Rigidbody>();
 //       //vDistance = topBound.transform.position.z - bottomBound.transform.position.z;

 //   }
	
	//void Update ()
 //   {
 //       if (press)
 //       {
 //           //if (pressed)
 //           //{
 //           //    //Bottom Bound
 //           //    if (bottomBound.transform.position.z < transform.position.z) { rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -vSpeed); }
 //           //    else { transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z); }

 //           //}
 //           //else
 //           //{
 //           //    //Top Bound
 //           //    if (topBound.transform.position.z > transform.position.z) { rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, vSpeed); }
 //           //    else { transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z); }

 //           //}
 //       }

 //       if (tap)
 //       {
            
 //           //if (tapped)
 //           //{
 //           //    vSpeed = vSpeed * -1;
 //           //    tapped = false;
 //           //}
 //           //if (vSpeed < 0)
 //           //{
 //           //    if (bottomBound.transform.position.z < transform.position.z) { rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, vSpeed); }
 //           //    else { transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z); }
 //           //}
 //           //else
 //           //{
 //           //    if (topBound.transform.position.z > transform.position.z) { rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, vSpeed); }
 //           //    else { transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z); }
 //           //}
 //       }
      
 //   }

   
}
