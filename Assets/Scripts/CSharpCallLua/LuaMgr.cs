using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

/// <summary>
/// Lua管理器 提供Lua唯一解析器
/// </summary>
public class LuaMgr : BaseManager<LuaMgr> {
    private LuaEnv luaEnv;
    /// <summary>
    /// 得到Lua中的_G
    /// </summary>
    public LuaTable Global {
        get {
            return luaEnv.Global;
        }
    }

    /// <summary>
    /// Lua解析器对象初始化
    /// </summary>
    public void Init() {
        if(luaEnv != null)
            return;
        luaEnv = new LuaEnv();
        luaEnv.AddLoader(MyCustomLoader);
        luaEnv.AddLoader(MyCustomABLoader);
        
    }
    /// <summary>
    /// 重定向函数
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    private byte[] MyCustomLoader(ref string filePath) {
        string path = Application.dataPath + "/Lua/" + filePath + ".lua";
        if(File.Exists(path))
            return File.ReadAllBytes(path);
        else
            Debug.Log("重定向失败");
        return null;
    }
    private byte[] MyCustomABLoader(ref string filePath) {
        #region 不用ABMgr
        //Debug.Log("Join in AB");
        ////加载AB包
        //string path = Application.streamingAssetsPath + "/lua";
        //AssetBundle ab = AssetBundle.LoadFromFile(path);
        ////加载Lua文件
        //TextAsset asset = ab.LoadAsset<TextAsset>(filePath + ".lua");
        //return asset.bytes;
        #endregion
        #region 使用ABMgr
        TextAsset asset = ABMgr.GetInstance().LoadRes<TextAsset>("lua",filePath + ".lua");
        if(asset != null)
            return asset.bytes;
        Debug.Log("重定向失败，文件名为：" + filePath);
        return null;
        #endregion

    }
    /// <summary>
    /// 执行Lua语言
    /// </summary>
    /// <param name="str"></param>
    public void DoString(string str) {
        if(luaEnv == null) {
            Debug.Log("解析器未初始化");
            return;
        }
        luaEnv.DoString(str);
    }
    public void DoLuaFile(string fileName) {
        string str = string.Format("require('{0}')",fileName);
        DoString(str);
    }
    /// <summary>
    /// 释放Lua对象
    /// </summary>
    public void Tick() {
        if(luaEnv == null) {
            Debug.Log("解析器未初始化");
            return;
        }
        luaEnv.Tick();
    }
    /// <summary>
    /// 销毁解析器
    /// </summary>
    public void Dispose() {
        if(luaEnv == null) {
            Debug.Log("解析器未初始化");
            return;
        }
        luaEnv.Dispose();
        luaEnv = null;
    }
}
