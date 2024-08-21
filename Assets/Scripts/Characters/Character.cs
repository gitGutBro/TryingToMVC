using UnityEngine;

public class Character
{
    private const float Epsilon = 0.01f;

    private float _direction;
    private float _speed;

    public float Direction 
    { 
        get => _direction;
        set => _direction = Normilize(value);
    }

    public float Speed 
    { 
        get => _speed; 
        set => Mathf.Max(value, 0); 
    }

    private float Normilize(float value)
    {
        if (Mathf.Abs(value) < Epsilon)
            return 0;

        if (value > 0)
            return 1;

        return -1;
    }
}