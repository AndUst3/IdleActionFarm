using UnityEngine;

public class VFXController : MonoBehaviour
{
    [SerializeField] private GameObject _grassEffect;
    [SerializeField] private GameObject _coinsEffect;
    [SerializeField] private Transform _scytheTransform;
    [SerializeField] private Transform _boxTransform;

    private void Awake()
    {
        GlobalEvents.GrassEffect.AddListener(EnableGrassEffect);
        GlobalEvents.CoinsEffect.AddListener(EnableCoinsEffect);
    }

    private void EnableGrassEffect()
    {
        Instantiate(_grassEffect, _scytheTransform.position, Quaternion.identity);
    }

    private void EnableCoinsEffect()
    {
        Instantiate(_coinsEffect, _boxTransform.position, Quaternion.identity);
    }
}
