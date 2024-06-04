using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;
#region Class1
public class Test1 {
    public void Speak(string str) {
        Debug.Log("Test1" + str);
    }
}
namespace MrTang {
    public class Test2 {
        public void Speak(string str) {
            Debug.Log("Test2" + str);
        }
    }
}
#endregion
#region Class2
public enum E_MyEnum {
    Idle, Move, Atk
}
#endregion
#region Class3
public class Lesson3 {
    public int[] array = new int[5] { 1,2,3,4,5 };
    public List<int> list = new List<int> { 1,2,3,4,5 };
    public Dictionary<int,string> dic = new Dictionary<int,string>();
    public void Test() {

    }
}
#endregion
#region Class4
[LuaCallCSharp]
public static class Tools {
    public static void Move(this Lesson4 obj) {
        Debug.Log(obj.name + " Move");
    }
}
public class Lesson4 {
    public string name = "kangkang";
    public void Speak(string str) {
        Debug.Log(str);
    }
    public static void Eat() {
        Debug.Log("Eatting");
    }
}
#endregion
#region Class5
public class Lesson5 {
    public int RefFun(int a,ref int b,ref int c,int d) {
        b = a + d;
        c = a - d;
        return 100;
    }
    public int OutFun(int a,out int b,out int c,int d) {
        b = a;
        c = d;
        return 200;
    }
    public int RefOutFun(int a,out int b,ref int c) {
        b = a * 10;
        c = a * 20;
        return 300;
    }
}
#endregion
#region Class6
public class Lesson6 {
    public int Calc() {
        return 100;
    }
    public int Calc(int a,int b) {
        return a + b;
    }
    public int Calc(int a) {
        return a;
    }
    public float Calc(float a) {
        return a;
    }
}
#endregion
#region Class7
public class Lesson7 {
    public UnityAction del;
    public event UnityAction eventAction;
    public void DoEvent() {
        if(eventAction != null) {
            eventAction();
        }
    }
    public void ClearEvent() {
        eventAction = null;
    }
}
#endregion
#region Class8
public class Lesson8 {
    public int[,] array = new int[2,3] { { 1,2,3 },{ 4,5,6 } };
}
#endregion
#region Class9
[LuaCallCSharp]
public static class Lesson9 {
    public static bool IsNull(this UnityEngine.Object obj) {
        return obj == null;
    }
}
#endregion
#region Class10
public static class Lesson10 {
    [CSharpCallLua]
    public static List<Type> csharpCallLuaList = new List<Type> { typeof(UnityAction<float>) };
}
#endregion
#region Class11
public class LuaCallCSharp : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
#endregion
#region Class12
public class Lesson12 {
    public interface ITest {
    }
    public class TestFather {
    }
    public class TestChild : TestFather,ITest {
    }
    public void TestFun1<T>(T a,T b) where T : TestFather {
        Debug.Log("有参数有约束的泛型方法");
    }
    public void TestFun2<T>(T a) {
        Debug.Log("有参数没约束的泛型方法");
    }
    public void TestFun3<T>() where T : TestFather {
        Debug.Log("没参数有约束的泛型方法");
    }
    public void TestFun4<T>(T a)where T: ITest {
        Debug.Log("有参数有约束，约束为接口的泛型方法");
    }
}
#endregion

