using UnityEngine;

namespace Assets.Scripts
{
    public class MakeHotdogs : MonoBehaviour
    {
        void Start()
        {
            Hotdog classicHotdog = new ClassicHotdog();
            Debug.Log($"{classicHotdog.GetName()} стоит {classicHotdog.GetCost()}р.");

            HotdogDecorator pickledHotdog = new WithPickles(classicHotdog);
            Debug.Log($"{pickledHotdog.GetName()} стоит {pickledHotdog.GetCost()}р.");

            HotdogDecorator sweetOnionHotdog = new WithSweetOnion(classicHotdog);
            Debug.Log($"{sweetOnionHotdog.GetName()} стоит {sweetOnionHotdog.GetCost()}р.");
        }
    }
}