using UnityEngine;

namespace Assets.Scripts
{
    public class MakeHotdogs : MonoBehaviour
    {
        void Start()
        {
            Hotdog classicHotdog = new ClassicHotdog();
            Debug.Log($"{classicHotdog.GetName()} ����� {classicHotdog.GetCost()}�.");

            HotdogDecorator pickledHotdog = new WithPickles(classicHotdog);
            Debug.Log($"{pickledHotdog.GetName()} ����� {pickledHotdog.GetCost()}�.");

            HotdogDecorator sweetOnionHotdog = new WithSweetOnion(classicHotdog);
            Debug.Log($"{sweetOnionHotdog.GetName()} ����� {sweetOnionHotdog.GetCost()}�.");
        }
    }
}