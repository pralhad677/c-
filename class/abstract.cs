namespace Asbtract1{
    public abstract class Person{
            public abstract int sum {get;}

            public abstract string getName();
    }

    class A:Person{
        public override int sum => 1*3;
        public override string getName()
        {
           return "jacob";
        }
    }
}