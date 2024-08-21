using UnityEngine;

public class PlayerFactory
{
    private readonly CharacterViewFactory _viewFactory;

    public PlayerFactory(CharacterViewFactory viewFactory) => 
        _viewFactory = viewFactory ?? throw new System.ArgumentNullException(nameof(viewFactory));

    public Player Create(Vector2 spawnPoint)
    {
        CharacterView view = _viewFactory.Create(spawnPoint);

        return new Player(view);
    }
}