using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] LayerMask layerToFind;

    [SerializeField] float radius = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded())
            {
                Jump();
            }
        }

    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    bool IsGrounded()
    {
        Vector3 offset = new Vector3(transform.position.x, transform.position.y - transform.localScale.y / 2, transform.position.z);
        return Physics.CheckSphere(offset, radius, layerToFind);
    }

    private void OnDrawGizmos()
    {
        Vector3 offset = new Vector3(transform.position.x, transform.position.y - transform.localScale.y / 2, transform.position.z);
        Gizmos.DrawWireSphere(offset, radius);
    }

}
