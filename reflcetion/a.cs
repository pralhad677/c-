// namespace Reflection1{
//     public class Person{
//         private readonly string name;

//         public Person(string name){
//             this.name = name;
//         }
//         public string getName(string name)=>name;
//     }

//     public class Main1{

//         public static void Main(string[] args){
//             Type type = typeof(Person);
//             var myMetohod = type.GetMethod("getName");
//             Object instance  = Activator.CreateInstance(type,new Object[] {"jacob"});
//            var data = myMetohod?.Invoke(instance,new Object[] {"jacob"});
//            Console.WriteLine(data);
//         }
//     }
// }