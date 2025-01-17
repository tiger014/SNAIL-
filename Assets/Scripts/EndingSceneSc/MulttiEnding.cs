using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MulttiEnding : MonoBehaviour
{
    public GameObject BadCanvas;
    public GameObject NormalCanvas;
    public GameObject TrueCanvas;
    public GameObject Badbgm;
    public GameObject Normalbgm;
    public GameObject Truebgm;
    public GameObject ButtonCanvas;
    public int Endscore = 0;
    public float endtime;

    void Start()
    {
        Debug.Log(Score.score);
        TrueCanvas.SetActive(false);
        NormalCanvas.SetActive(false);
        BadCanvas.SetActive(false);
        Truebgm.SetActive(false);
        Normalbgm.SetActive(false);
        Badbgm.SetActive(false);
        ButtonCanvas.SetActive(false);
        endtime = 27f;
    }
    void Update()
    {
        Endscore = Score.score;
        endtime -= Time.deltaTime;

        if (Endscore == 5) //トゥルー
        {
            Debug.Log("トゥルー");
            TrueCanvas.SetActive(true);
            Truebgm.SetActive(true);
        }
        if ((Endscore > 2) && (Endscore < 5)) //ノルマ達成
        {
            Debug.Log("ノルマ達成");
            NormalCanvas.SetActive(true);
            Normalbgm.SetActive(true);
        }
        if (Endscore < 3) //ノルマ以下
        {
            Debug.Log("ノルマ以下");
            BadCanvas.SetActive(true);
            Badbgm.SetActive(true);
        }

        if (endtime <= 0f)
        {
            SceneManager.LoadScene("StartScene");
        }
        else if (endtime <= 5f)
        {
            //ButtonCanvas.SetActive(true);
        }
    }
}
