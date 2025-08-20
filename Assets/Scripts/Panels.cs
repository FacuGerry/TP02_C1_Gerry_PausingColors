using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Panels : MonoBehaviour
{

    [Header("Panel Settings")]
    [SerializeField] private GameObject panelPause;
    [SerializeField] private GameObject panelOptions;
    [SerializeField] private GameObject panelCredits;

    [Header("Button Settings")]
    [SerializeField] private Button btnPlay;
    [SerializeField] private Button btnOptions;
    [SerializeField] private Button btnCredits;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnBackOptions;
    [SerializeField] private Button btnBackCredits;

    [Header("Slider Settings")]
    [SerializeField] private Slider speedPlayer1;
    [SerializeField] private Slider speedPlayer2;

    private bool isPause = false;

    void Awake()
    {
        btnPlay.onClick.AddListener(Resume);
        btnOptions.onClick.AddListener(OnOptionsClicked);
        btnCredits.onClick.AddListener(OnCreditsClicked);
        btnExit.onClick.AddListener(OnExitClicked);
        btnBackOptions.onClick.AddListener(OnBackOptionsClicked);
        btnBackCredits.onClick.AddListener(OnBackCreditsClicked);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
        isPause = true;
        panelPause.SetActive(true);
    }

    void Resume()
    {
        Time.timeScale = 1;
        isPause = false;
        panelPause.SetActive(false);
    }

    void OnOptionsClicked()
    {
        panelPause.SetActive(false);
        panelOptions.SetActive(true);
    }

    void OnCreditsClicked()
    {
        panelPause.SetActive(false);
        panelCredits.SetActive(true);
    }

    void OnExitClicked()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }

    void OnBackOptionsClicked()
    {
            panelOptions.SetActive(false);
            panelPause.SetActive(true);
    }

    void OnBackCreditsClicked()
    {
            panelCredits.SetActive(false);
            panelPause.SetActive(true);
    }

}
