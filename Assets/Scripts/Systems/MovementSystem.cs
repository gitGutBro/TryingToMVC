using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementSystem : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    private void Awake() => 
        _rigidbody2D = GetComponent<Rigidbody2D>();

    public void Move(float direction, float speed) => 
        _rigidbody2D.SetVelocity(direction * speed, 0);
}