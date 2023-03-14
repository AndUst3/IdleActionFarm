using UnityEngine;

public class PlayerController : CharacterAnimations
{
    [SerializeField] public DynamicJoystick _joystick;

    private Rigidbody _rb;
    private Transform _transform;
    private Animator _animator;
    
    public float speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
        _animator = GetComponent<Animator>();

        speed = 2.7f;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        _rb.velocity = new Vector3(_joystick.Horizontal * speed, _rb.velocity.y,
            _joystick.Vertical * speed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            _transform.rotation = Quaternion.LookRotation(_rb.velocity);
            _animator.SetFloat(WalkSpeed, Vector3.ClampMagnitude(_rb.velocity, 1).magnitude);
        }
        else
            _animator.SetFloat(WalkSpeed, 0);
    }
}
