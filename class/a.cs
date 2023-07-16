namespace Class1{
    public class Person {
        private const double pi = 3.14;

        public readonly int age;
        public Person(int age1){
            // Console.WriteLine("parent");
            age=age1;
        }
        public virtual void Parent(){
            Console.WriteLine("parent");
        }
        public virtual void Parent1(){
            Console.WriteLine("in parent");
        }
    }

    public class A:Person{
        private string name="jacob";
        public A(int age):base(age){
            Console.WriteLine("parent ");
        }

        public int getAge(){
            return base.age;
        }
        public override void Parent()
        {
           Console.WriteLine("child");
        }
        public new void Parent1(){
            Console.WriteLine("in child");
        }
    }
}