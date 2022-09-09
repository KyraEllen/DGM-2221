using UnityEngine;

[CreateAssetMenu]

public class MyFloatData : ScriptableObject
{
    public float speed; 

    public void SetSpeed(float num)
    {
        speed = num;
    }

    public void UpdateSpeed(float num)
    {
        speed += num;
    }
}
