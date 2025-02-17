using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    private Transform characterTransform;
    private float lastPositionX;

    void Start()
    {
        characterTransform = transform; // Сохраняем ссылку на Transform
        lastPositionX = characterTransform.position.x;
    }

    void Update()
    {
        float currentPositionX = characterTransform.position.x;

        // Проверяем изменение позиции по X и переворачиваем спрайт
        if (currentPositionX > lastPositionX)
        {
            characterTransform.localScale = new Vector3(1, 1, 1); // Обычное положение
        }
        else if (currentPositionX < lastPositionX)
        {
            characterTransform.localScale = new Vector3(-1, 1, 1); // Разворот по X
        }

        lastPositionX = currentPositionX; // Обновляем прошлую позицию
    }
}
