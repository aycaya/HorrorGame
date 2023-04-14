using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerControl : MonoBehaviour
{

    public GameObject arkaPlanSfx; 
    public float walkingSpeed = 7.5f;
   

    public float gravity = 20.0f;
    public Camera playerCam;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    public TextMeshProUGUI ActionText;

    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;
   

    [HideInInspector]
    public bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        StartCoroutine(DeleteCoroutine());
    }

    void Update()
    {
        
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        
        
        float curSpeedX = canMove ? (walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        
        characterController.Move(moveDirection * Time.deltaTime);

        
        if (canMove)
        {
           
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCam.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
    }
    IEnumerator DeleteCoroutine()
    {
        ActionText.text = "Çabuk! Buradan bir an önce çýkmalýsýn çýkýþ kapýsý için anahtarý bulmaya çalýþ ve çok dikkatli ol...";
        
        yield return new WaitForSeconds(5f);
        arkaPlanSfx.SetActive(true);
        ActionText.text = " ";
    }
}

