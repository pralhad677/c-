// namespace A{
//     public class Person{
//         private string? name;
//         public string Name{
//             get{
//                 return this.name!;
//             }
//             set{
//                 this.name =  value;
//             }
//         }
//         public string getName(){
//             return this.name!;
//         }

//         public string getName(string name){
//             return name;
//         }


//         public static void Main(string[] args){
//             Person p = new();
//             p.name = "jacob";
//             Console.WriteLine(p.getName());
//             Console.WriteLine(p.getName("ryan"));
//         }
//     }
// }