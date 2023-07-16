// namespace A{

//     public static class ListExtensions{
//         public static  List<int> evenData(this List<int> list){
//                 return list.Where(x=>x%2 ==0).ToList();
//         }
//     }

//     public class Person{
//         public readonly List<int> list = new List<int>(){1,2,3,4,5,6,7};

//         public static void Main(string[] args){
//             Person p = new(); 
//             foreach(var item in p.list.evenData()){
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }