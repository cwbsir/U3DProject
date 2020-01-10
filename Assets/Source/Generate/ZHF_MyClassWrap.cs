using System;
using LuaInterface;
using ZHF;
 
public class ZHF_MyClassWrap {
    public static void Register(LuaState L) {
        L.BeginClass(typeof(ZHF.MyClass), typeof(System.Object));
        L.RegFunction("Display", Display);
        L.RegConstant("Zhang", 23333);
        L.EndClass();
    }
    [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
    static int Display(IntPtr L) {
        try {
            ToLua.Push(L, "sad");
            return 1;
        } catch (Exception e) {
            return LuaDLL.toluaL_exception(L, e);
        }
    }
}