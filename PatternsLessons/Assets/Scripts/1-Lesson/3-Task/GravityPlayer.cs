using UnityEngine;

public class GravityPlayer : PlayerMovement
{
    private float _gravity = -9.81f;
    private float _velocity;

    public void Gravity()
    {
        _velocity += _gravity * Time.deltaTime;
        
    }
}
