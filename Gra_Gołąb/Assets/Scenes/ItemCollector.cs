using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int obwarzanki = 0;
    //[SerializeField] private Text obwarzankiText;

    private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("obwarzanek"))
            {
                Destroy(collision.gameObject);
                obwarzanki++;
                Debug.Log("obwarzanki:" + obwarzanki);
                //obwarzankiText.text = "obwarzanki:" + obwarzanki;
            }
        }
}

// to co zakomentowane nie dziala nw czemu!