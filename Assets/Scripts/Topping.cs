using UnityEngine;

[CreateAssetMenu(fileName = "NewTopping", menuName = "Hotdog/Topping")]
public class Topping : ScriptableObject
{
    public string toppingName;
    public int cost;
}