using UnityEngine;  //引用Unity API (函式庫 : Unity 屬性、功能)

//類別 class 定義一個物件
//語法 : class類別名稱
// : MonoBehavior可以將此腳本掛在Unity物件上
//類別必須放在物件上才會執行

public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1. 大小寫有區分
    //2. 括號成對出現

    [Header("汽車一號")]
    public Cars car1;
    [Header("汽車二號")]
    public Cars car2;

    //事件 : 在特定時間會依指定次數執行的方法(名稱為藍色)
    //開始事件 : 撥放遊戲時執行一次 - 初始事件

    void Start()
    {
        print("Hello world");

        //取得 get
        print("汽車一號的CC數:"+car1.cc);
        print("汽車二號的CC數:"+car2.cc);
        //設定set
        car1.cc = 500;
        car1.brand = "TOYOTA";
        car1.weight = 500.64f;
        car1.brake = true;

    }

    
    void Update()
    {
        
    }
}
