using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class OnClick : MonoBehaviour
{
    private Button _button;
    private int _counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();

    }

    public void incrementCounter(TMP_Text counterTMPText)
    {
        _counter++;
        counterTMPText.text = _counter.ToString();
    }
    
}
