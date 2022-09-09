using UnityEngine;

[CreateAssetMenu]

public class MyFloatData : ScriptableObject
{
    public float value;

    public void Speed(float num)
    {
        value += num;
    }
}
