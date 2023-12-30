using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float sensitivity = 2.0f;

    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0.0f;

    void Update()
    {
        // 움직임 처리
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        moveDirection = new Vector3(moveHorizontal, 0, moveVertical);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;

        // 플레이어 회전 처리
        float rotationY = Input.GetAxis("Mouse X") * sensitivity;
        rotationX -= Input.GetAxis("Mouse Y") * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90, 90);

        transform.Rotate(0, rotationY, 0);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
        
    void FixedUpdate()
    {
        // 움직임 적용
        GetComponent<Rigidbody>().velocity = moveDirection;
    }
}
