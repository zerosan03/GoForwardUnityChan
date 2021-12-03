using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //�i�ǉ��j

public class UIController : MonoBehaviour
{

    // �Q�[���I�[�o�[�e�L�X�g
    private GameObject gameOverText;

    // ���s�����e�L�X�g
    private GameObject runLengthText;

    // ����������
    private float len = 0;

    // ���鑬�x
    private float speed = 0.03f;

    // �Q�[���I�[�o�[�̔���
    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {
        // �V�[���r���[����I�u�W�F�N�g�̎��̂���������
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            // �������������X�V����
            this.len += this.speed;

            // ������������\������
            this.runLengthText.GetComponent<Text>().text = "Distance:  " + len.ToString("F2") + "m";
        }

        // �Q�[���I�[�o�[�ɂȂ����ꍇ�i�ǉ��j
        if (this.isGameOver == true)
        {
            // �N���b�N���ꂽ��V�[�������[�h����i�ǉ��j
            if (Input.GetMouseButtonDown(0))
            {
                //SampleScene��ǂݍ��ށi�ǉ��j
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        // �Q�[���I�[�o�[�ɂȂ����Ƃ��ɁA��ʏ�ɃQ�[���I�[�o�[��\������
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }
}