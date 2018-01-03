using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }
}