using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuHandller : MonoBehaviour
{
    public static MenuHandller Instance;
    public TextMeshProUGUI bestScore;
    public GameObject _inputField;
    private TMP_InputField _inputFieldText;

    private void Awake()
    {
        Instance = this;
        _inputFieldText = _inputField.GetComponent<TMP_InputField>();
        LoadBestPlayer();
    }

    public void StartButtonClick()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerNameInput()
    {
        PlayerProfile.Instance.lastPlayerName = _inputFieldText.text;
    }

    void LoadBestPlayer()
    {
        _inputFieldText.text = PlayerProfile.Instance.bestPlayerName;
        bestScore.text = $"Best Score:{PlayerProfile.Instance.bestPlayerName}:{PlayerProfile.Instance.bestScore}";
    }
}
