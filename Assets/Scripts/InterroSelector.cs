using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterroSelector : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;

    private int currentSus;

    private void Awake()
    {
        SelectSus(0);
    }

    private void SelectSus(int _index)
    {
        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void changeSus(int _change)
    {
        currentSus += _change;
        SelectSus(currentSus);
    }

    public void confirmSus()
    {
        PlayerPrefs.SetInt("Character Selected", currentSus);
        SceneManager.LoadScene("Interragation");
    }
}