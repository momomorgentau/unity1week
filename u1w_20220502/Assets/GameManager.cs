using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    static public GameManager instance;
    public enum COLOR
    {
        NONE = 0,
        RED = 1,
        GREEN = 2,
        BLUE = 3,
        YELLOW = 4,
        MAX = 5,
    }
    public enum SHAPE
    {
        NONE = 0,
        SPADE = 1,
        HEART = 2,
        DIAMOND = 3,
        CLUB = 4,
        MAX = 5
    }


    void Awake()
    {
        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {

            Destroy(gameObject);
        }
    }

    public string Enum2StringColor(COLOR color)
    {
        string color_name = "";
        switch (color)
        {
            case GameManager.COLOR.RED:
                color_name = "red";
                break;
            case GameManager.COLOR.GREEN:
                color_name = "green";
                break;
            case GameManager.COLOR.BLUE:
                color_name = "blue";
                break;
            case GameManager.COLOR.YELLOW:
                color_name = "yellow";
                break;
            case GameManager.COLOR.NONE:
                color_name = "black";
                break;
            default:
                Debug.LogError("Error : GameManager.Enum2StringColor");
                break;
        }
        return color_name;    
    }


    public string Enum2StringShape(SHAPE shape)
    {
        string shape_name = "";
        switch (shape)
        {
            case GameManager.SHAPE.SPADE:
                shape_name = "spade";
                break;
            case GameManager.SHAPE.HEART:
                shape_name = "heart";
                break;
            case GameManager.SHAPE.DIAMOND:
                shape_name = "diamond";
                break;
            case GameManager.SHAPE.CLUB:
                shape_name = "club";
                break;
            case GameManager.SHAPE.NONE:
                shape_name = "circle";
                break;
            default:
                Debug.LogError("Error : GameManager.Enum2StringShape");
                break;
        }
        return shape_name;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
