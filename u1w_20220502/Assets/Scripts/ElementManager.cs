using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour
{
    public GameManager.COLOR m_color { get; private set; }
    public GameManager.SHAPE m_shape { get; private set; }


    public void SetElement(GameManager.COLOR color,GameManager.SHAPE shape)
    {
        m_color = color;
        m_shape = shape;
    }

    public GameManager.COLOR GetColor()
    {
        return m_color;
    }
    public GameManager.SHAPE GetShape()
    {
        return m_shape;
    }


}
