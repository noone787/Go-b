using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public ItemCollector itemCollector;
    public int poziom;
    public int punkty_do_levelowania;
    public UnityEngine.UI.Image image;
    public TextMeshProUGUI textMeshPro;
    
    void Start()
    {

    }

    
    
    void Update()
    {
        if (itemCollector.obwarzanki >= 5) {
            itemCollector.obwarzanki = 0;
            poziom++;
            punkty_do_levelowania++;
        }
        image.fillAmount = itemCollector.obwarzanki/5f ;
        textMeshPro.text = poziom.ToString();
    }
}
