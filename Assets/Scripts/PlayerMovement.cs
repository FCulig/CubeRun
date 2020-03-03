using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000;
    public float sidewaysForce = 500;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            GlobalGM.Instance.isPaused = true;
            GlobalGM.Instance.levelPaused = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene("GamePaused");
        }
    }
}
