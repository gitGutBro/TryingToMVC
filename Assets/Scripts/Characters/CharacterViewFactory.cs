using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class CharacterViewFactory
{
    private readonly CharacterView _prefab;
    private readonly CharacterConfig _config;

    public CharacterViewFactory(CharacterView prefab, CharacterConfig config)
    {
        _prefab = prefab != null ? prefab : throw new ArgumentNullException(nameof(prefab));
        _config = config != null ? config : throw new ArgumentNullException(nameof(config));
    }

    public CharacterView Create(Vector2 spawnPoint)
    {
        CharacterView view = Object.Instantiate(_prefab, spawnPoint, Quaternion.identity);

        Character character = new()
        {
            Speed = _config.Speed,
        };

        CharacterPresenter presenter = new(view, character);

        view.Construct(presenter);

        return view;
    }
}