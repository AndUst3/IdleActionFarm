using UnityEngine;

public class PlayerHit : CharacterAnimations
{
    [SerializeField] private GameObject _scythe;
    private PlayerController _player;
    private Animator _animator;

    public bool isNearGrass;

    private void Awake()
    {
        _scythe.gameObject.SetActive(false);
        _player = GetComponent<PlayerController>();
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Grass"))
        {
            isNearGrass = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Grass"))
        {
            isNearGrass = false;
        }
    }

    private void Update()
    {
        if (isNearGrass && (_player._joystick.Horizontal == 0 || _player._joystick.Vertical == 0))
        {
            _scythe.gameObject.SetActive(true);
            _animator.SetBool(IsAttack, true);
        }
        else
        {
            _animator.SetBool(IsAttack, false);
            _scythe.gameObject.SetActive(false);
        }
    }
}
