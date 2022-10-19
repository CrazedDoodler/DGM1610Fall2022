using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    public void ResetValue(float num)
    {
        value = num;
    }
    public void UpdateValue(float num)
    {
        value += num;
    }
}
