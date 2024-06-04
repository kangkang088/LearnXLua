using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class Lesson2_Loader : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        LuaEnv env = new LuaEnv();
        env.AddLoader(MyCustomLoader);
        env.DoString("require('Main')");
    }
    private byte[] MyCustomLoader(ref string filePath) {
        string path = Application.dataPath + "/Lua/" + filePath + ".lua";
        Debug.Log(path);
        if(File.Exists(path))
            return File.ReadAllBytes(path);
        else
            Debug.Log("重定向失败");
        return null;
    }
    // Update is called once per frame
    void Update() {

    }
}
