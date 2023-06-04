using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Earth;
    public Transform target; // ������ �� ������������� ������� �����
    public float distance = 10f; // ���������� �� ������ �� ������� �����
    public float speed = 5f; // �������� �������� ������

    private Vector3 offset; // �������� ����� ������� � �������� �����

    void Start()
    {
        // ��������� ��������� �������� ����� ������� � �������� �����
        offset = transform.position - target.position;
    }

    void Update()
    {
        // ��������� �������� ������� ������
        Vector3 desiredPosition = target.position + offset;

        // ������ ���������� ������ � �������� �������
        transform.position = Vector3.Lerp(transform.position, desiredPosition, speed * Time.deltaTime);

        transform.LookAt(Earth);
    }
}
