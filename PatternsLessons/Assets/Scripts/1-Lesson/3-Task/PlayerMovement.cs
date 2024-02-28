using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Character movement stats")]
    [SerializeField] private float _moveSpeed;
    private float _xHorizontal;
    private float _zVertical;

    private CharacterController _characterController;

    private GravityPlayer _gravity;

    private Vector3 _moveDirection;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        Move();
        _gravity.Gravity();
    }

    private void Move()
    {
        _xHorizontal = Input.GetAxis("Horizontal");
        _zVertical = Input.GetAxis("Vertical");

        _moveDirection = transform.right * _xHorizontal + transform.forward * _zVertical;

        _characterController.Move(_moveDirection * _moveSpeed * Time.deltaTime);
    }
}
