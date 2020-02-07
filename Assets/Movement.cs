using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 offset;

    public GameObject center;

    public Transform ForwardPivot;
    public Transform BackwardPivot;
    public Transform LeftPivot;
    public Transform RightPivot;

    public uint step = 9;

    public float speed = 0.01f;

    private bool input = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (input)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                StartCoroutine(MoveForward());
                input = false;
            }
            
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                StartCoroutine(MoveBackward());
                input = false;
            }
            
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                StartCoroutine(MoveLeft());
                input = false;
            }
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                StartCoroutine(MoveRight());
                input = false;
            }
        }
    }

    public IEnumerator MoveForward()
    {
        for (int i = 0; i < (90/step); i++)
        {
           transform.RotateAround(ForwardPivot.position, Vector3.right, step); 
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = transform.position;
        input = true;
    }
    
    public IEnumerator MoveBackward()
    {
        for (int i = 0; i < (90/step); i++)
        {
            transform.RotateAround(BackwardPivot.position, Vector3.left, step); 
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = transform.position;
        input = true;
    }
    
    public IEnumerator MoveLeft()
    {
        for (int i = 0; i < (90/step); i++)
        {
            transform.RotateAround(LeftPivot.position, Vector3.forward, step); 
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = transform.position;
        input = true;
    }
    
    public IEnumerator MoveRight()
    {
        for (int i = 0; i < (90/step); i++)
        {
            transform.RotateAround(RightPivot.position, Vector3.back,  step); 
            yield return new WaitForSeconds(speed);
        }

        center.transform.position = transform.position;
        input = true;
    }
}
