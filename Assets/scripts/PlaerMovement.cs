using UnityEngine;

public class PlaerMovement : MonoBehaviour

{

    public float speed, rotationSpeed;

    private float xInput, yInput;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

        transform.Rotate(Vector3.up, xInput * rotationSpeed * Time.deltaTime); //Rotate the player around the y-axis based on horizontal input

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse); //Add an upward force to the player when the space key is pressed
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(yInput * transform.forward * speed); //Move the player forward based on vertical input

    }
}
