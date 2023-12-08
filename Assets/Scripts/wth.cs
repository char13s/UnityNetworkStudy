using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class wth : MonoBehaviour
{
    TextMeshProUGUI text;
    private void Start() {
        text = GetComponent<TextMeshProUGUI>();
        TestRelay.code += ok;
    }
    private void ok(string k) {
        text.text = k;
    }
}
