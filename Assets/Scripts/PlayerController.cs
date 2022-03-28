using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speedMovement;
    public float speedRotation;
    public Transform viewPoint;
    private Rigidbody _rb;
    // Start is called before the first frame update

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ViewMovement();
    }
    private void Movement()
    {
        float inputX = Input.GetAxis("Vertical");
        float inputY = Input.GetAxis("Horizontal");

        if (inputX != 0 || inputY != 0)
        {
            Vector3 direction = transform.forward * inputX + transform.right * inputY;
            _rb.MovePosition(transform.position + direction * speedMovement * Time.deltaTime);
        }
    }

    private void ViewMovement()
    {
        float mouseY = Input.GetAxis("Mouse X");
        float mouseX = Input.GetAxis("Mouse Y");

        if (mouseY != 0 || mouseX != 0)
        {
            transform.Rotate(new Vector3(0, mouseY * speedRotation * Time.deltaTime * 5f, 0));
            viewPoint.Rotate(new Vector3(mouseX * speedRotation * Time.deltaTime * 5f, 0, 0));
        }
    }
}
