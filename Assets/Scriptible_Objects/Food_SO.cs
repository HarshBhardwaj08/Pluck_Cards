using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[CreateAssetMenu(fileName = "Foods", menuName = "Food_Description", order = 1)]
public class Food_SO : ScriptableObject
{  
    public enum vitamin {vitaminA,Vitamin_B,Vitamin_C,Vitamin_D }
    public Sprite foods;
    public string foodname;
    public vitamin food_vitamin;
    public string total_Protien;

    public Sprite Texture { get { return foods; } }
    public string name_food {  get { return foodname; }  }

    public vitamin name_food_vitamin { get { return food_vitamin; } }

    public string total_protien { get {  return total_protien; } }

}
