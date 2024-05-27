using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPanel : MonoBehaviour
{
    /// <summary>
    /// save load manager
    /// </summary>
    SaveLoadManager m_saveLoadManager = null;

    /// <summary>
    /// own index
    /// </summary>
    public int m_index = -1;

    /// <summary>
    /// own type
    /// </summary>
    public int m_type = -1;

    /// <summary>
    /// dice imfo text
    /// </summary>
    public Text m_exText = null;

    /// <summary>
    /// start
    /// </summary>
    private void Start()
    {
        m_saveLoadManager = GameObject.Find("SaveLoadManager").GetComponent<SaveLoadManager>();
    }

    /// <summary>
    /// click load btn
    /// </summary>
    public void ClickLoadBtn()
    {
        m_saveLoadManager.m_groupName = m_exText.text;
        m_saveLoadManager.DiceLoadBtn(m_index, m_type);
    }

    /// <summary>
    /// click panel del btn
    /// </summary>
    public void ClickDelBtn()
    {
        m_saveLoadManager.m_groupName = m_exText.text;
        m_saveLoadManager.DiceDelBtn(m_index, m_type);
    }
}
