using System.Runtime.InteropServices;
using UnityEngine;

public class ManagedPluginLab : MonoBehaviour
{
    [DllImport("ManagedPluginLab", EntryPoint = "TestSort")]
    public static extern void TestSort(int[] a, int length);

    public int[] a;
    void Start()
    {
      TestSort(a, a.Length);
    }
}
