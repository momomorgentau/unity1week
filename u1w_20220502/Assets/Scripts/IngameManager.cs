using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngameManager : MonoBehaviour
{
    const float WIDTH = 7.0f;
    const float HEIGHT = 3.5f;

    const int ELEMNT_COUNT = 150;

    

    [SerializeField] GameObject m_elementObject;


    private Button m_backButton;
    private Score m_score = new Score();
    private List<Text> m_colorTexts = new List<Text>();
    private List<Text> m_shapeTexts = new List<Text>();

    private void Init()
    {
        m_backButton = GameObject.Find("CanvasFW/Button1").GetComponent<Button>();

        m_colorTexts = new List<Text>();
        m_shapeTexts = new List<Text>();
        for (int i = 1; i < (int)GameManager.COLOR.MAX; ++i)
        {
            m_colorTexts.Add(GameObject.Find($"CanvasFW/Elements/Color{i}/Text").GetComponent<Text>());
        }
        for (int i = 1; i < (int)GameManager.SHAPE.MAX; ++i)
        {
            m_shapeTexts.Add(GameObject.Find($"CanvasFW/Elements/Shape{i}/Text").GetComponent<Text>());
        }

        for (int i = 0; i < (int)GameManager.COLOR.MAX-1; ++i)
        {
            m_colorTexts[i].text = m_score.m_colorCount[i].ToString();
        }
        for (int i = 0; i < (int)GameManager.SHAPE.MAX-1; ++i)
        {
            m_shapeTexts[i].text = m_score.m_shapeCount[i].ToString();
        }


        m_backButton.onClick.AddListener(() =>SceneManager.instance.ChangeScene("Title"));
    }
    // Start is called before the first frame update
    void Start()
    {
        Init();
        GameInitialize();
    }

    private void GameInitialize()
    {
        for (int _ = 0; _ < ELEMNT_COUNT; ++_)
        {
            CreateElement();
        }

    }

    private void CreateElement()
    {
        var color = (GameManager.COLOR)Random.Range(1, (int)GameManager.COLOR.MAX);
        var shape = (GameManager.SHAPE)Random.Range(1, (int)GameManager.SHAPE.MAX);
        string color_name = GameManager.instance.Enum2StringColor(color);
        string shape_name = GameManager.instance.Enum2StringShape(shape);
        string resources_path = $"Elements/{shape_name}_{color_name}";

        Vector3 coord = new Vector3(Random.Range(-WIDTH, (float)WIDTH), Random.Range(-HEIGHT, (float)HEIGHT), 0);

        var elemnt_object = Instantiate(m_elementObject, coord, Quaternion.identity);
        elemnt_object.transform.Find("sprite").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(resources_path);
        ElementManager element_manager = elemnt_object.transform.GetComponent<ElementManager>();
        element_manager.SetElement(color, shape);
    }
}
