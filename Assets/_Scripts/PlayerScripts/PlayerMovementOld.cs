using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOld : MonoBehaviour
{
    public float playerMoveSpeed = 3f;
    private float rotationY = -90f;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotationControll();
    }

    private void FixedUpdate()
    {
        PlayerMovementControll();
    }

    private void PlayerMovementControll()
    {
        rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * playerMoveSpeed,
                                  rb.velocity.y,
                                  Input.GetAxisRaw("Vertical") * playerMoveSpeed);
    }

    private void PlayerRotationControll()
    {
        if (Input.GetAxisRaw("Horizontal") > 0 )
        {
            rb.rotation = Quaternion.Euler(0, -rotationY, 0);
        } else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rb.rotation = Quaternion.Euler(0, rotationY, 0);
        }
    }
}
