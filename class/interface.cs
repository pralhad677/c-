 namespace Interface1
 {
    public abstract class Person{

            public abstract string getName();
    }

    class P:Person{
        public int age {get;set;}

        public P(int age1){
            age=age1;
        }
        public override string getName()
        {
         return "jacob";
        }
    }
 }