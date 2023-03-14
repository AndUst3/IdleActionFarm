using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] public Text _pointsLabel;
    [SerializeField] public Text _coinsLabel;
    [SerializeField] private GameObject _characterBag;

    public static int pointsCount;
    public static double coinsCount;

    private void Awake()
    {
        _characterBag.SetActive(false);
    }

    private void Update()
    {
        _pointsLabel.text = pointsCount.ToString();
        _coinsLabel.text = coinsCount.ToString();

        if (pointsCount != 0)
            _characterBag.SetActive(true);

        else if (pointsCount == 0) 
            _characterBag.SetActive(false);
    }
}
