using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Earth;
    public Transform target; // Ссылка на трансформацию планеты Земля
    public float distance = 10f; // Расстояние от камеры до планеты Земля
    public float speed = 5f; // Скорость движения камеры

    private Vector3 offset; // Смещение между камерой и планетой Земля

    void Start()
    {
        // Вычисляем начальное смещение между камерой и планетой Земля
        offset = transform.position - target.position;
    }

    void Update()
    {
        // Вычисляем желаемую позицию камеры
        Vector3 desiredPosition = target.position + offset;

        // Плавно перемещаем камеру к желаемой позиции
        transform.position = Vector3.Lerp(transform.position, desiredPosition, speed * Time.deltaTime);

        transform.LookAt(Earth);
    }
}
