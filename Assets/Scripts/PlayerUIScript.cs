using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUIScript : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        Stats.onHealthBarChange += OnHealthBarChange;
        Stats.onHealthChange += OnHealthChange;
    }
    private void OnHealthBarChange(int val) {
        healthBar.maxValue = val;
    }
    private void OnHealthChange(int val) {
        healthBar.value = val;
    }
}
