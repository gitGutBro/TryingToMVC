using UnityEngine;

public static class ExtensionMethods
{
    public static void SetVelocity(this Rigidbody2D rigidbody2D, float x, float y) =>
        rigidbody2D.velocity = new Vector2(x, y);
}