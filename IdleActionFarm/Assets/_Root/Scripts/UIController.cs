using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _resumeButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;

    private void Awake()
    {
        _pauseButton.onClick.AddListener(OnPause);
        _resumeButton.onClick.AddListener(ResumePlay);
        _restartButton.onClick.AddListener(RestartGame);
        _exitButton.onClick.AddListener(ExitGame);
        _menu.gameObject.SetActive(false);
    }

    private void OnPause()
    {
        Time.timeScale = 0f;
        _menu.gameObject.SetActive(true);
    }

    private void ResumePlay()
    {
        Time.timeScale = 1f;
        _menu.gameObject.SetActive(false);
    }

    private void RestartGame()
    {
        Main.pointsCount = 0;
        Main.coinsCount = 0;

        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    private void ExitGame() => Application.Quit();
}
