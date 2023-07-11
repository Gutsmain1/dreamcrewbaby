using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    public bool statement = false;
    public string verb = "fuck";
    public string noun = "dog";
    public string adjective = "cat fucking";
    public int number = 134;
    public string pluralNoun = "elephants";
    public float percent = 43.3F;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The is statement is {statement}. I did not {verb} the {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this.";
    }

    // Update is called once per frame
    void Update()
}
