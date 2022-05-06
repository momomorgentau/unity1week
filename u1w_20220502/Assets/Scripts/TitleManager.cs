using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{

    private Button m_StartButton;
    private Button m_ResultButton;
    private Button m_QuitButton;

    private void Init()
    {
        m_StartButton = GameObject.Find("Canvas/Buttons/Button1").GetComponent<Button>();
        m_ResultButton = GameObject.Find("Canvas/Buttons/Button2").GetComponent<Button>();
        m_QuitButton = GameObject.Find("Canvas/Buttons/Button3").GetComponent<Button>();

        m_StartButton.onClick.AddListener(() => SceneManager.instance.ChangeScene("Ingame"));
    }

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
