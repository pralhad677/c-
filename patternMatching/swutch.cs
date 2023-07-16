namespace Switch1{
    public class switch1{

        public readonly int age;


        public switch1(int age1){
            age=age1;
        }

      public void a(){
        switch(age){
            case 30 :
                Console.WriteLine("30");
            break;
            case 35:
            Console.WriteLine("35");
            break;
            default:
            Console.WriteLine("default");
            break;
        }
      }
    }
}