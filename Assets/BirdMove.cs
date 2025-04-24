using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMove : MonoBehaviour
{
    public GameObject bird;
    public float speed;
    public float force;
    Rigidbody rb;
    private void Start()
    {
        rb = bird.GetComponent<Rigidbody>();
    }
    void Update()
    {
        bird.transform.Translate(0, 0, -speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, force ,rb.linearVelocity.z);       
        }
    }
}
