using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    private Transform characterTransform;
    private float lastPositionX;

    void Start()
    {
        characterTransform = transform; // ��������� ������ �� Transform
        lastPositionX = characterTransform.position.x;
    }

    void Update()
    {
        float currentPositionX = characterTransform.position.x;

        // ��������� ��������� ������� �� X � �������������� ������
        if (currentPositionX > lastPositionX)
        {
            characterTransform.localScale = new Vector3(1, 1, 1); // ������� ���������
        }
        else if (currentPositionX < lastPositionX)
        {
            characterTransform.localScale = new Vector3(-1, 1, 1); // �������� �� X
        }

        lastPositionX = currentPositionX; // ��������� ������� �������
    }
}
