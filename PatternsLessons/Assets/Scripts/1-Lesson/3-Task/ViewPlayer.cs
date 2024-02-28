using UnityEngine;

[RequireComponent(typeof(ViewPlayer))]
public class ViewPlayer : MonoBehaviour
{
    [SerializeField] public float _sensivity;
    public Transform _player;
    private float _xRotation;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * _sensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _sensivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        _player.Rotate(Vector3.up * mouseX);
    }
}
