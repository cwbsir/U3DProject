using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using UnityEditor;
using UnityEngine.UI;

public class Driver:MonoBehaviour
{
    private LuaState lua;

    private LuaFunction tickFunc;
    private LuaFunction onGuiFunc;
    private LuaFunction fixedTickFunc;

    private float m_LastUpdateShowTime = 0f;    //上一次更新帧率的时间;

    public int targetFrameRate = 10;

    private GameObject obj;
    private UnityEngine.Font font;
    private UnityEngine.UI.Text component;

    void Start()
    {
        
        lua = new LuaState();
        lua.OpenLibs(LuaDLL.luaopen_pb);
        lua.OpenLibs(LuaDLL.luaopen_lpeg);
        lua.OpenLibs(LuaDLL.luaopen_bit);
        lua.OpenLibs(LuaDLL.luaopen_socket_core);
        lua.LuaSetTop(0);
        
        LuaBinder.Bind(lua);
        DelegateFactory.Init();
        LuaCoroutine.Register(lua, this);

        font = new UnityEngine.Font("Arial");
        Debug.Log("==================="+font.fontSize);

        lua.AddSearchPath(Application.dataPath + "/Lua");        
        lua.AddSearchPath(Application.dataPath + "/ToLua/Lua");

        lua.Start();

        lua.DoFile("Main.lua");

        LuaFunction start = lua.GetFunction("main");
        start.Call("params");
        start.Dispose();
        start = null;

        tickFunc = lua.GetFunction("tickFunc");
        onGuiFunc = lua.GetFunction("onGuiFunc");
        fixedTickFunc = lua.GetFunction("fixedTickFunc");

        obj = new GameObject("label11");
        obj.AddComponent(typeof(UnityEngine.RectTransform));
        component = (UnityEngine.UI.Text)obj.AddComponent(typeof(UnityEngine.UI.Text));
        component.text = "Hello World!!";


        m_LastUpdateShowTime = Time.realtimeSinceStartup;
    }

    void Awake ()
    {
        print("Awake=======");
        Application.targetFrameRate = targetFrameRate;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.realtimeSinceStartup - m_LastUpdateShowTime;
        tickFunc.Call(deltaTime);

        m_LastUpdateShowTime = Time.realtimeSinceStartup;
    }

    void OnGUI()
    {
        component.font = font;
        onGuiFunc.Call();
    }

    void FixedUpdate()
    {
        fixedTickFunc.Call(Time.realtimeSinceStartup);
    }

    public void Close() {
        lua.Dispose();
        lua = null;

        tickFunc.Dispose();
        tickFunc = null;
        fixedTickFunc.Dispose();
        fixedTickFunc = null;
    }
}
