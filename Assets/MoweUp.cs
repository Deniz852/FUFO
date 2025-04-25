using UnityEngine;

public class MoveUpOnTrigger : MonoBehaviour
{
    public float targetYPosition = 5f; // Целевая позиция по оси Y
    public float moveSpeed = 2f;      // Скорость движения
    private bool shouldMove = false;   // Флаг для начала движения
    private Vector3 targetPosition;    // Целевая позиция

    private void Start()
    {
        // Рассчитываем целевую позицию (сохраняем X и Z текущие, меняем только Y)
        targetPosition = new Vector3(transform.position.x, targetYPosition, transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, если в коллайдер вошел объект с тегом "Player" (можно изменить на нужный)
        if (other.CompareTag("Player"))
        {
            shouldMove = true; // Активируем движение
        }
    }

    private void Update()
    {
        if (shouldMove)
        {
            // Плавно перемещаем объект к целевой позиции
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // Проверяем, достигли ли мы целевой позиции
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                shouldMove = false; // Останавливаем движение
            }
        }
    }
}