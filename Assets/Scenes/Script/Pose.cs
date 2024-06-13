using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false); // �|�[�Y���j���[���\��
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // ���Ȃ��̃|�[�Y�g���K�[�ɍ��킹�ĕύX
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // �Q�[�����Ԃ��~
        Debug.Log("stop");
        pauseMenuUI.SetActive(true); // �|�[�Y���j���[��\��
    }

    void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // �Q�[�����Ԃ��ĊJ
        pauseMenuUI.SetActive(false); // �|�[�Y���j���[���\��
    }
}