using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text nameText;
    string[] names = new string[] { "Matt", "Joanne", "Robert","Candy", "Nolan", "Emily", "Riley", "Nicholas", "Adeline", "Parker", "Jonathan", "Lillian", "Xavier", "Jaxon", "Delilah", "Zoe", "Henry", "Miles", "Abigail", "Aurora", "Robert", "Ivy", "Maya", "Jameson", };
  
    void Start()
    {
        nameText.text = names[Random.Range(0, names.Length - 1)];
    }

   
}
