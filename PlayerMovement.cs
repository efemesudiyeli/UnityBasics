using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // HandleMovementTransform();
        // HandleMovementTransform2();
    }

    void FixedUpdate()
    {
        // HandleMovementRigidbody();
        // HandleMovementRigidbodyVelocity();
        HandleMovementRigidbodyMovePosition();
    }

    void HandleMovementTransform()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, 0, moveZ);

        transform.position += direction * moveSpeed * Time.deltaTime;

        Debug.Log(direction);
    }

    void HandleMovementTransform2()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, 0, moveZ);

        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }

    void HandleMovementRigidbody()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, 0, moveZ);

        _rigidbody.AddForce(direction * moveSpeed, ForceMode.Force);
    }

    void HandleMovementRigidbodyVelocity()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, 0, moveZ);

        _rigidbody.velocity = direction * moveSpeed;
    }

    void HandleMovementRigidbodyMovePosition()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(moveX, 0, moveZ);

        _rigidbody.MovePosition(transform.position + direction * moveSpeed * Time.deltaTime);

        RotateCharacterToDirection(direction);
    }

    void RotateCharacterToDirection(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.15f);
        }

    }
}
