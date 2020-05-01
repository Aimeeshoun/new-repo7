
using UnityEngine;
[CreateAssetMenu]
public class floatdata : ScriptableObject
{

        public float value = 3f;
        public float minValue = 0;
        public float maxValue = 2f;
    
        public void UpdateValue(float amount)
        {
            value += amount;
        }

        public void UpdateValueRange (float amount)
        {
            if (value <= maxValue)
            {
                UpdateValue(amount);
            }
            else
            {
                value = maxValue;
            }
        
            if (value >= minValue)
            {
                UpdateValue(amount);
            }
            else
            {
                value = minValue;
            }
        
        }
}
