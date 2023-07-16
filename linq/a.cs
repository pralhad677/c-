//  namespace A{

//    public class Person{
//          public   string? name {get;set;}
//          public int id {get;set;}
//          public bool isStudent {get;set;}


//       public static   void Main(string[] args ){
//             List<Person> list = new List<Person>{
//                   new Person{
//                      id=1,
//                      name="jacob",
//                      isStudent=true,
//                   },
//                   new Person{
//                      id=2,
//                      name="ryan",
//                      isStudent=false,
//                   },
//                   new Person{
//                      id=3,
//                      name="ryan",
//                      isStudent=true,
//                   },
//             };

//             Func<Person,Person> del  = (p)=>{
//                p.isStudent = !p.isStudent;
//                return p;
//             };

//             var list1 = list.Select(del);

//             var orderdList = list1.OrderBy(_=>_.name).ThenByDescending(_=>_.id);
//             var DistinctByList = list1.DistinctBy(_=>_.name);
//             var DistinctList = list1.Distinct();

//             var single = list1.SingleOrDefault(_=>_.id ==5);
//             Console.WriteLine(single);


//             var paginate = list1.Skip(2).Take(1);
//             foreach(var item in paginate){
//                 Console.WriteLine(item.id);
//             }
//         foreach(var item in orderdList){
//             Console.WriteLine("name is {0} and id is {1}",item.name,item.id);
//         }
//         foreach(var item in DistinctByList){
//             Console.WriteLine("name is {0} and id is {1}",item.name,item.id);
//         }
//         foreach(var item in DistinctList){
//             Console.WriteLine("name is {0} and id is {1}",item.name,item.id);
//         }

//         var all = list1.All(x=>x.id>0);
//         var any = list1.All(x=>x.id>1);
//         var contains = list1.SingleOrDefault(x=>x!.name!.Contains("jacob"));
//         var sum = list1.Aggregate(0,(c,item)=>c+item.id);
//         Console.WriteLine("aggreGate {0}",sum);
//         Console.WriteLine("all {0}",all);
//         Console.WriteLine("any {0}",any);
//         Console.WriteLine("contains {0}",contains!.id);

//             foreach(var item in list1){
//                Console.WriteLine(item.isStudent);
//             }

//             var data = from item in list1
//                         where item.isStudent=true 
//                         select item; 


//              foreach(var item in data){
//                Console.WriteLine(item.id);
//              }     

//              int? data1 =null;
//              if(data1.HasValue){
//                Console.WriteLine(data1.Value);          
               
//                  }
//                  Console.WriteLine(data1.GetValueOrDefault());

//                 //  var task1 = Task.Run(()=>{
//                 //      return 3;
//                 //  });
//                 //  int a = await task1;
//                 //  int b = task1.GetAwaiter().GetResult();
//                 //  Console.WriteLine(a);
//                 //  Console.WriteLine(b);
//       }  
//    }
//  }