//  namespace Join1{
//     public class Customer{

//         public string? name {get;set;}
//         public int id {get;set;}

//         public Customer(string name,int id){
//             this.id = id;
//             this.name = name;
//         }
//     }
//     public class Order{
//         public int id{get;set;}
//         public string? orderName{get;set;}
//         public int CutomerId {get;set;}
//         public Order(string orderName,int id,int CutomerId){
//             this.id = id;
//             this.CutomerId=CutomerId;
//             this.orderName = orderName;
//         }

//     }

//     public class Main1{
//         public static void Main(string[] args){
//             List<Customer> customers;
//             List<Order> orders;
//             Func<int,Customer> myDelegate =(num)=>new Customer($"myName {num}",num);
//             Func<int,Order> myDelegate1 =(num)=>new Order($"pizza {num}",num,num);
//             customers= Enumerable.Range(0,10).ToList().Select(myDelegate).ToList();
//            Console.WriteLine(customers);
          
//            foreach(var item in customers){
//             Console.WriteLine("id is {0} and name is ${1}",item.id,item.name);


//            }

//            orders=Enumerable.Range(0,10).ToList().Select(myDelegate1).ToList();
//              foreach(var item in orders){
//             Console.WriteLine("id is {0} and name is ${1} and customerId is ${2}",item.id,item.orderName,item.CutomerId);


//            }
//            var joinData = from customer in customers
//                             join order in orders on customer.id equals order.CutomerId
//                             select new {
//                                 customerId=customer.id,
//                                 orderName=order.orderName
//                             };


//                   foreach  (var item in joinData){
//                   Console.WriteLine("customerId is {0} and orderName is {1}",item.customerId,item.orderName);  
//                     // Console.WriteLine();
//                   }        
//         }
//     }
// }