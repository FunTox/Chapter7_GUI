using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    private void Start()
    {
        settingsPopup.Close();
    }

    private void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }
    public void OnOpenSettings()
    {
        settingsPopup.Open();
    }

    public void OnPointerDown()
    {
        Debug.Log("pointer down");
    }
}
