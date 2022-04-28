using System;
using UnityEngine;
[Serializable]
public class FloatReference
{
    public bool useConstant = false;
    public float ConstantValue;
    public FloatReference Variable;

    public float Value
    {
        get
        {
            return useConstant ? ConstantValue : Variable.Value;
        }
    }
}
