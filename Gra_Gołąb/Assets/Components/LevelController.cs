using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using Unity.Collections;
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
        float x = itemCollector.obwarzanki;
        image.fillAmount = x/5 ;
        textMeshPro.text = poziom.ToString();
    }
}
