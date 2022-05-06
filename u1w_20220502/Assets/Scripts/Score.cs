using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public List<int> m_colorCount = new List<int>();
    public List<int> m_shapeCount = new List<int>();

    public Score()
    {
        for (int i = 0; i < (int)GameManager.COLOR.MAX; ++i)
        {
            m_colorCount.Add(0);
        }
        for (int i = 0; i < (int)GameManager.SHAPE.MAX; ++i)
        {
            m_shapeCount.Add(0);
        }
    }

}
