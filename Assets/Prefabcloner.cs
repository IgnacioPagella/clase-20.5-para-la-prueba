using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prefabcloner : MonoBehaviour
{
    public GameObject prefab;
    public Text inputCloneAmount;
    public Text displayCloneLeft;
    public InputField IField;
    public int counter;
    


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        displayCloneLeft.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClonerPrefab()
    {
        if (inputCloneAmount.text != "")
        {
            IField.readOnly = true;
            int cloneAmount = int.Parse(inputCloneAmount.text);
            if (counter < cloneAmount)
            {
                Instantiate(prefab);
                counter++;
                displayCloneLeft.text = (int.Parse(inputCloneAmount.text) - counter).ToString();

            }
        }
        else
        {
            displayCloneLeft.text = "No hay";
        }
        else     
        {
            displayCloneLeft.text = "ERROR, ingrese un valor";
        }
       
    }
}
