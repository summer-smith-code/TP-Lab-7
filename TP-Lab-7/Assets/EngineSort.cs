using System;
using UnityEngine;

public class EngineSort : MonoBehaviour
{
    public void TestSort(int[] a, int length)
    {
        Array.Sort(a, 0, length);
    }
}
