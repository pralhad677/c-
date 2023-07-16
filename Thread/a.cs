namespace Thread1{
    public class thread1{
        public void Main(){

            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            new Thread(()=>{
                
            }).Start();
        }
    }
}