using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        startPosition = transform.position;
        startRotation = Quaternion.identity;
        RollDice();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();
        }
    }

    void RollDice()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.position = startPosition;
        transform.rotation = Random.rotation;

        // Increase force and torque values
        Vector3 force = new Vector3(
            Random.Range(-2f, 2f),
            Random.Range(7f, 9f),  // was 5-6 before
            Random.Range(-2f, 2f)
        );
        Vector3 torque = new Vector3(
            Random.Range(-15f, 15f),
            Random.Range(-15f, 15f),
            Random.Range(-15f, 15f)
        );

        rb.AddForce(force, ForceMode.Impulse);
        rb.AddTorque(torque, ForceMode.Impulse);
    }

}
