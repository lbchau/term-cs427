using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool collided;
    public GameObject collidedTo;
    public Animator animatorCol;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PickUpObj")
        {
            collided = true;
            collidedTo = collision.gameObject;
            if (Input.GetKey(KeyCode.E))
            {
                animator.SetTrigger("PickUp");
            }
        }
        if (collision.gameObject.tag == "Door")
        {
            collided = true;
            collidedTo = collision.gameObject;
            animatorCol = collision.gameObject.GetComponent<Animator>();
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("getE");
                animator.SetTrigger("OpenDoor");
                animatorCol.SetBool("open", true);
            }
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "PickUpObj")
        {
            collided = false;
            collidedTo = null;
        }
    }
}
