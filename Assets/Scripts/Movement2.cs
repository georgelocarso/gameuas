using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    protected Collider coll;
    public GameObject panelPause;
    public CharacterController controller;
    public Transform cam;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    public float speed = 6f;
    
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    // Update is called once per frame



    void Start(){
        controller = GetComponent<CharacterController>();
        coll = GetComponent<Collider>();
        Cursor.visible = false;
        panelPause.SetActive (false);

    }
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        
        //pause game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panelPause.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else if (panelPause.activeSelf == false)
        {
            Time.timeScale = 1;
            Cursor.visible = false;
        }

        
        
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        


        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            {
            if (Grounded())
            {
                print("Huuray");
                playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            }
            }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
        bool Grounded()
        {
            return Physics.Raycast(transform.position, Vector3.down, coll.bounds.extents.y + 0.1f);
        }
    }
}
