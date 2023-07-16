//  namespace A{
//     public class B{
//         public int x {get;set;}
//         public int y { get;set;}
//         public B(int x,int y){
//             this.x = x;
//             this.y = y;
//         }

//         public static B operator +(B b1,B b2){
//             return new B(b1.x+b2.x,b1.y+b2.y);
//         }

//         public static B operator -(B b1,B b2){
//             return new B(b1.x-b2.x,b1.y-b2.y);
//         }


//         public static void Main(string[] args){
//             B b1 = new(1,2);
//             B b2 = new(3,4);
//             var data = b1+b2;
//             var data1 = b1-b2;
//             Console.WriteLine(data.x);
//             Console.WriteLine(data1.y);
//         }
//     }
//  }