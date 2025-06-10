using UnityEngine;
using XLua;

[LuaCallCSharp]
public static class LuaAPIWrapper
{
    public static void DontDestroyOnLoad(UnityEngine.GameObject gameObject)
    {
        UnityEngine.Object.DontDestroyOnLoad(gameObject);
    }
}