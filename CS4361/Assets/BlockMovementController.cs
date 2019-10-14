using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovementController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += 5 * Vector3.left;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += 5 * Vector3.right;
        }
    }
}
