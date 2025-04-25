using UnityEngine;

public class MoveUpOnTrigger : MonoBehaviour
{
    public float targetYPosition = 5f; // ������� ������� �� ��� Y
    public float moveSpeed = 2f;      // �������� ��������
    private bool shouldMove = false;   // ���� ��� ������ ��������
    private Vector3 targetPosition;    // ������� �������

    private void Start()
    {
        // ������������ ������� ������� (��������� X � Z �������, ������ ������ Y)
        targetPosition = new Vector3(transform.position.x, targetYPosition, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���������, ���� � ��������� ����� ������ � ����� "Player" (����� �������� �� ������)
        if (other.CompareTag("Player"))
        {
            shouldMove = true; // ���������� ��������
        }
    }

    private void Update()
    {
        if (shouldMove)
        {
            // ������ ���������� ������ � ������� �������
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // ���������, �������� �� �� ������� �������
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                shouldMove = false; // ������������� ��������
            }
        }
    }
}