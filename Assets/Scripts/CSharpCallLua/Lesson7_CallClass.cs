using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CallLuaInClass {
    public int testInInt;
}
public class CallLuaClass {
    public int i;
    public int testInt;
    public bool testBool;
    public float testFloat;
    public string testString;
    public UnityAction testFunc;
    public CallLuaInClass testInClass;
}
public class Lesson7_CallClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        CallLuaClass clc = LuaMgr.GetInstance().Global.Get<CallLuaClass>("TestClass");
        Debug.Log(clc.i);
        Debug.Log(clc.testInt);
        Debug.Log(clc.testBool);
        Debug.Log(clc.testFloat);
        Debug.Log(clc.testString);
        Debug.Log(clc.testInClass.testInInt);   
        clc.testFunc.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
