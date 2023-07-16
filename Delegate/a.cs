//  namespace A{
//    public delegate string getName();
//    public class Person{
//       public readonly string name;
//       public Person(string name){
//          this.name = name;
//       }

//       public string a(){
//          return this.name;
//       }

//       public string b(){
//          Console.WriteLine("asd");
//          return "ryan";
//       }


//    public static void Main(string[] args){
//          Person p = new("jacob");
//          getName g = p.a;
//          getName g1 = p.b;
//          getName mg = (getName)Delegate.Combine(g,g1);
//          Console.WriteLine(mg());
//    }
//    }
//  }