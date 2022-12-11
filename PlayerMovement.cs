using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rb;

    float forwardForce = 6000f;
    float sidewaysForce = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            _rb.AddForce(sidewaysForce * Time.deltaTime , 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey("a"))
        {
            _rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (_rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
