
using UnityEngine;

[CreateAssetMenu]
public class intdata : ScriptableObject

    {

        public int value = 1;



        public void UpdateValue(int number)

        {

            value += number;

        }

    }
