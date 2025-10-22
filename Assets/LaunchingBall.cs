using UnityEngine;

public class LaunchingBall : MonoBehaviour
{
    public float launchForce=250.0f;
    public float spinForce=0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            launchForce+=5.0f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            launchForce-=5.0f;
        }

        if(Input.GetKey(KeyCode.A))
        {
            Transform t=gameObject.transform;
            t.Translate(0.001f,0.0f,0.0f);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Transform t=gameObject.transform;
            t.Translate(-0.001f,0.0f,0.0f);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            spinForce-=0.2f;
        }
        else if(Input.GetKey(KeyCode.E))
        {
            spinForce+=0.2f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Rigidbody rb=GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0.0f,0.0f,-launchForce));
            rb.AddTorque(new Vector3(0.0f,0.0f,spinForce));
        }
    }
}
