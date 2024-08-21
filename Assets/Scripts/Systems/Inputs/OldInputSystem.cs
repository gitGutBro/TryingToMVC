using System;
using UnityEngine;

public class OldInputSystem : IInputSystem
{
    private readonly OldInputSystemConfig _config;
    private readonly InputMap _map;

    public OldInputSystem(OldInputSystemConfig config)
    {
        _config = config != null ? config : throw new ArgumentNullException(nameof(config));
        _map = new InputMap();
    }

    public IInputMap Map => _map;

    public void Update()
    {
        _map.IsAttackButtonPressed = Input.GetMouseButton(0);
        _map.HorizontalDirection = 0;

        if (Input.GetKey(_config.LeftButton))
            _map.HorizontalDirection--;

        if (Input.GetKey(_config.RightButton))
            _map.HorizontalDirection++;
    }
}