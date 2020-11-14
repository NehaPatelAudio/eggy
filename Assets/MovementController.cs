using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 3f;
    private float currentSpeed = 0f;
    private float speedSmoothVelocity = 0f;
    private float speedSmoothTime = 0.1f;
    private float rotationSpeed = 0.1f;
    private float gravity = 3f;
    public SpawnObject target;
    public int numberofBars;
    public GoldBar goldbar;
    public Text counter;
    

    private Transform mainCameraTransform = null;

    private CharacterController controller = null;
    private Animator animator = null;
    

    private void Start()

    {



        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        mainCameraTransform = Camera.main.transform;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(target != null)
            {
          

                if (target.Spawn() == true) 
                {
                    
                }

                
            }
            if (goldbar != null)
            {
                goldbar.gameObject.SetActive(false);

                Debug.Log("attempt deactiate gold bar");
                
                    numberofBars = numberofBars + goldbar.goldbarstoadd;
                counter.text = numberofBars.ToString();
                
            }
        }
        
        Move();
        
  


    }
    private void Move()
    {
        Vector2 movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector3 forward = mainCameraTransform.forward;
        forward.y = 0; // y value set to 0 to accomodate camera tilt
        Vector3 right = mainCameraTransform.right;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 desiredMoveDirection = (forward * movementInput.y + right * movementInput.x).normalized;
        Vector3 gravityVector = Vector3.zero;

        if(!controller.isGrounded)
        {
            gravityVector.y -= gravity;
        }

        if(desiredMoveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), rotationSpeed);

        }

        float targetSpeed = movementSpeed * movementInput.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);
        Vector3 finalV = desiredMoveDirection * currentSpeed * Time.deltaTime;
        
        controller.Move(desiredMoveDirection * currentSpeed * Time.deltaTime);

        controller.Move(gravityVector * Time.deltaTime);

        
        if (desiredMoveDirection.x != 0 || desiredMoveDirection.z != 0)
        {
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }
            
}
