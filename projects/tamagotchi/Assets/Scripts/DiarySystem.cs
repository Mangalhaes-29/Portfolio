using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class DiarySystem : MonoBehaviour
{
    public GameObject diaryPanel;

    public TMP_InputField diaryInput;

    public TMP_Text pageText;

    private List<string> pages = new List<string>();

    private int currentPage = 0;

    void Start()
    {
        pages.Add("");

        UpdatePage();
    }

    public void OpenDiary()
    {
        diaryPanel.SetActive(true);

        UpdatePage();
    }

    public void CloseDiary()
    {
        SaveCurrentPage();

        diaryPanel.SetActive(false);
    }

    public void NextPage()
    {
        SaveCurrentPage();

        currentPage++;

        if (currentPage >= pages.Count)
        {
            pages.Add("");
        }

        UpdatePage();
    }

    public void PreviousPage()
    {
        SaveCurrentPage();
        if (currentPage > 0)
        {
            currentPage--;
        }
        UpdatePage();
    }

    void SaveCurrentPage()
    {
        pages[currentPage] = diaryInput.text;
    }

    void UpdatePage()
    {
        diaryInput.text = pages[currentPage];
        pageText.text = "Página " + (currentPage + 1);
    }
}