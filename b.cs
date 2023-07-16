//  namespace A{
//     public class Person1{

//         public IEnumerable<int> getInt(int x,string y){
//            yield return 1;
//            yield return 2;
//            yield return 3;

//         }

//         public static void Main(string[] args){
//                 Person1  p = new();

//                 List<int> list = p.getInt(y:"asd",x:123).ToList();
//                 foreach(var item in list){
//                     Console.WriteLine(item);
//                 }

//                 var x = delegate (){
//                         return 3;
//                 };
//                 Console.WriteLine(x());
//         }
//     }
//  }