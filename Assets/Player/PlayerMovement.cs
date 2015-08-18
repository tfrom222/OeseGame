using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode forwardKey;
    public KeyCode backwardsKey;
    public KeyCode jumpKey;

    bool isJumping;

    Rigidbody rBody;

    // Use this for initialization
    void Start()
    {
        print(gameObject.name);

      rBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(leftKey) && !isJumping)
        {
            print("Left");


            rBody.AddRelativeForce(new Vector3( -15, 0, 0), ForceMode.Acceleration);

        }

        if (Input.GetKey(rightKey) && !isJumping)
        {
            print("Right");
            rBody.AddRelativeForce(new Vector3(15, 0, 0), ForceMode.Acceleration);


        }

        if (Input.GetKey(forwardKey) && !isJumping)
        {
            print("Forward");

            rBody.AddRelativeForce(new Vector3(0, 0, 15), ForceMode.Acceleration);

        }

        if (Input.GetKey(backwardsKey) && !isJumping)
        {
            print("Backwards");

            rBody.AddRelativeForce(new Vector3(0, 0, -15), ForceMode.Acceleration);

        }

        if (Input.GetKeyDown(jumpKey))
        {
            print("Jump");
            isJumping = true;
            rBody.AddRelativeForce(new Vector3(0, 500, 0), ForceMode.Force);

        }
        if (Input.GetKeyUp(jumpKey))
        {
            
            isJumping = false;
           

        }
	}
}
