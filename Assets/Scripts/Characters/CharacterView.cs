using UnityEngine;

[RequireComponent(typeof(MovementSystem))]
public class CharacterView : PresentableView<CharacterPresenter>, ICharacterView 
{
    private MovementSystem _movement;

    private void Awake() => 
        _movement = GetComponent<MovementSystem>();

    void ICharacterView.Move(float direction, float speed) => 
        _movement.Move(direction, speed);

    public void SetDirection(float direction) => 
        Presenter.SetDirection(direction);

    public void Shoot()
    {

    }
}