using UnityEngine;

namespace Assets.Scripts
{
    public class MakeHotdogs : MonoBehaviour
    {
        public Topping[] toppings;

        void Start()
        {
            Hotdog classicHotdog = new ClassicHotdog();
            Debug.Log($"{classicHotdog.GetName()} стоит {classicHotdog.GetCost()}р.");

            for (int i = 0; i < toppings.Length; i++)
            {
                HotdogDecorator sweetOnionHotdog = new ToppingDecorator(classicHotdog, toppings[i]);
                Debug.Log($"{sweetOnionHotdog.GetName()} стоит {sweetOnionHotdog.GetCost()}р.");
            }
        }
    }
}