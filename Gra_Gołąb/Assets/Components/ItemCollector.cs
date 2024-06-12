using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public TMP_Text obwarzankiText;
    public int obwarzanki = 0;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("obwarzanek"))
            {
                Destroy(collision.gameObject);
                obwarzanki++;
                Debug.Log("obwarzanki:" + obwarzanki);
            }
        }
    void Update() {
        obwarzankiText.text = "obwarzanki: " + obwarzanki.ToString();
    }
}
