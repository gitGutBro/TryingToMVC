using System;

public class CharacterPresenter : Presenter
{
    private readonly ICharacterView _view;
    private readonly Character _character;

    public CharacterPresenter(ICharacterView view, Character character)
    {
        _view = view ?? throw new ArgumentNullException(nameof(view));
        _character = character ?? throw new ArgumentNullException(nameof(character));
    }

    public void SetDirection(float direction) => 
        _character.Direction = direction;

    public override void Update(float deltaTime) => 
        _view.Move(_character.Direction, _character.Speed * deltaTime);
}