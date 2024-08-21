public class Player
{
    private CharacterView _view;

    public Player(CharacterView view) => 
        _view = view != null ? view : throw new System.ArgumentNullException(nameof(view));

    public void HandleInput(InputMap inputMap)
    {
        if (inputMap.IsAttackButtonPressed)
        {
            Attack();

            return;
        }

        Move(inputMap);
    }

    private void Attack()
    {
        _view.Shoot();
        _view.SetDirection(0);
    }

    private void Move(InputMap inputMap) => 
        _view.SetDirection(inputMap.HorizontalDirection);
}