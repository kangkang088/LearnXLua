using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;

[CSharpCallLua]
public interface ICSharpCallInterface {
    int testInt {
        get; set;
    }
    bool testBool {
        get;set;
    }
    float testFloat {
        get;set;
    }
    string testString {
        get;set;
    }
    UnityAction testFunc {
        get;set;
    }
}
public class Lesson8_CallInterface : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        ICSharpCallInterface obj = LuaMgr.GetInstance().Global.Get<ICSharpCallInterface>("TestClass");
        Debug.Log(obj.testInt);
        Debug.Log(obj.testBool);
        Debug.Log(obj.testFloat);
        Debug.Log(obj.testString);
        obj.testFunc.Invoke();
    }

    // Update is called once per frame
    void Update() {

    }
}
