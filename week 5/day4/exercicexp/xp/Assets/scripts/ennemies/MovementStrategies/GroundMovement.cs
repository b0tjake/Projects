using UnityEngine;

public class GroundMovement : IMovementStrategy
{
    public void Move(Transform self, Transform target, float speed)
    {
        self.position = Vector2.MoveTowards(
            self.position,
            target.position,
            speed * Time.deltaTime
        );
    }
}