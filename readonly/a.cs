using System;
namespace J1{
[AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
class MyAttribute:Attribute{
    public  string message;
    public MyAttribute(string message){
        this.message = message;
    }
}
[My("hello jacob")]
public class Person{

    public const int age=35;

    public int getAge(){
        return Person.age;
    }
    public void Main(){
        Type t = typeof(Person);
        object[] attributes = t.GetCustomAttributes(typeof(MyAttribute),true);
        Console.WriteLine(attributes);
    }
}
}