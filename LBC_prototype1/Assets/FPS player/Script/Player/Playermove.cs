using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour {


    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;

    [SerializeField] private float walkSpeed, runSpeed;
    [SerializeField] private float runBuildUpSpeed;
    [SerializeField] private KeyCode runKey;
    [SerializeField] private KeyCode walkKey;
    public bool start;

    private float movementSpeed;
    //public Animator marcus;

    private CharacterController charController;

    public int noweapon = 1;
    public int withweapon = 0;

    public bool startmove;


    private void Awake()
    {
        charController = GetComponent<CharacterController>();
      
    }

    private void Update()
    {
        if (start == true)
        {
            PlayerMovement();
        }
    }

    public void arm(bool weapon)
    {
        noweapon = 0;
        withweapon = 1;
        Debug.Log("WITH WEAPON");
    }

    private void PlayerMovement()
    {
       
        float horizInput = Input.GetAxis(horizontalInputName);

        float vertInput = Input.GetAxis(verticalInputName);

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(Vector3.ClampMagnitude(forwardMovement + rightMovement, 1.0f) * movementSpeed);
      
        SetMovementSpeed();
    }

    private void SetMovementSpeed()
    {
        if (noweapon == 1 && withweapon == 0)
        {
           
            //marcus.SetBool("walk", false);
            //marcus.SetBool("run", false);

            if (Input.GetKey(runKey))
            {
                //marcus.SetBool("run", true);
                //marcus.SetBool("walk", false);
              
                movementSpeed = Mathf.Lerp(movementSpeed, runSpeed, Time.deltaTime * runBuildUpSpeed);
            }
            else if (Input.GetKey(walkKey))
            {

                //marcus.SetBool("walk", true);
                //marcus.SetBool("run", false);
              
                movementSpeed = Mathf.Lerp(movementSpeed, walkSpeed, Time.deltaTime * runBuildUpSpeed);
            }
        }
        else if (noweapon == 0 && withweapon == 1)
        {
        
            //marcus.SetBool("Wwalk", false);
            //marcus.SetBool("Wrun", false);
            //marcus.SetBool("run", false);
            //marcus.SetBool("walk", false);

            if (Input.GetKey(runKey))
            {
                //marcus.SetBool("Wrun", true);
                //marcus.SetBool("Wwalk", false);
               
                //marcus.SetBool("run", false);
                //marcus.SetBool("walk", false);
                movementSpeed = Mathf.Lerp(movementSpeed, runSpeed, Time.deltaTime * runBuildUpSpeed);
            }
            else if (Input.GetKey(walkKey))
            {

                //marcus.SetBool("Wwalk", true);
                //marcus.SetBool("Wrun", false);
            
                //marcus.SetBool("run", false);
                //marcus.SetBool("walk", false);
                movementSpeed = Mathf.Lerp(movementSpeed, walkSpeed, Time.deltaTime * runBuildUpSpeed);
            }
        }
    }

   

}
