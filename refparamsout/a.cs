// namespace A{
//    public class Person{
//       public int id {get;set;}
//       public string? name {get;set;}

//       public Person(int id,string name){
//          this.id =id;
//          this.name = name;
//       }

//    public int getId(){return this.id;}

//    public int getId(string id){
//    int data;
//        int.TryParse(id,out data);
//        return data;
//    }

//    public int[] getList(params int[] list){
//       return list;
//    }
//    public void a(out int a,out int b){
//       a=3;
//       b=4;

//    }
//    public void b(ref int a){
//       a =5;
//    }

//    public static void Main(string[] args){
//       Person p =new(1,"jacob");
//       Console.WriteLine(p.getList(1,2,3,4));
//       int a,b;
//       p.a(out a,out b);
//       Console.WriteLine("{0} {1}",a,b);
//       int x=45;
//       p.b(ref x);
//       Console.WriteLine($"{x}");

//    }
 
//    }
// }