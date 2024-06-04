using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using XLua;
[Hotfix]
public class HotfixTest {
    public HotfixTest() {
        Debug.Log("Hotfix构造函数");
    }
    public void Speak(string str) {
        Debug.Log(str);
    }
    ~HotfixTest() {
        
    }
}
[Hotfix]
public class HotfixTest2<T> {
    public void Test(T str) {
        Debug.Log(str);
    }
}
[Hotfix]
public class HotFixMain : MonoBehaviour
{
    private int[] array = new int[] { 1,2,3 };
    public int Age {
        get {
            return 0;
        }
        set {
            Debug.Log(value);
        }
    }
    public int this[int index] {
        get {
            if(index >= array.Length || index < 0) {
                Debug.Log("索引不正确");
                return 0;
            }
            return array[index];
        }
        set {
            if(index >= array.Length || index < 0) {
                Debug.Log("索引不正确");
                return ;
            }
            array[index] = value;
        }
    }
    HotfixTest hotfixTest;
    event UnityAction<int> myEvent;
    private void TestTest(int a) {
        Debug.Log(a);
    }
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");

        HotfixTest2<string> t1 = new HotfixTest2<string>();
        t1.Test("123");
        HotfixTest2<int> t2 = new HotfixTest2<int>();
        t2.Test(1);


        myEvent += TestTest;
        myEvent -= TestTest;


        this[99] = 100;
        print(this[99]);
        this.Age = 100;
        Debug.Log(this.Age);
        //Debug.Log(Add(10,20));
        //Speak("kangkang");
        //hotfixTest = new HotfixTest();
        //hotfixTest.Speak("xixixixixi");

        //StartCoroutine(TestCoroutine());
    }
    IEnumerator TestCoroutine() {
        while(true) {
            yield return new WaitForSeconds(1f);
            Debug.Log("协程打印一次");
        }
    }

    void Update()
    {
        
    }
    public int Add(int a,int b) {
        return 0;
    }
    public static void Speak(string str) {
        Debug.Log("Hahahha");
    }
}
