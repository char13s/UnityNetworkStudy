using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
public class SendCode : MonoBehaviour
{
    public static event UnityAction<string> sendCode;
    [SerializeField] private TMP_InputField text;
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        button=GetComponent<Button>();
        button.onClick.AddListener(() => {
            sendCode.Invoke(text.text);
        });
    }

}
