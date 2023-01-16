using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float horizontalMove = 10f;
    public float verticalMove = 10f;

    private Vector3 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        movement = new Vector3(horizontalMove, verticalMove,0);
    }

    private void FixedUpdate()
    {
        transform.position = transform.position + movement * Time.fixedDeltaTime;
    }
}
