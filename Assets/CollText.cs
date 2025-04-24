using UnityEngine;

public class CollText : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public Vector3 target;
    private void Start()
    {
        text1.SetActive(false);
        text2.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.position = target;
        text1.SetActive(true);
        text2.SetActive(true);
    }
}
