 namespace A{
    public record Person(string name,int age){


        public static void Main(string[] args){
            Person p = new("jacob",25);
            Person p1 = new("jacob",25);
            Person p2 = p with {name="ryan"};
            Console.WriteLine(p==p1);
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(p2.name);
            // p2.name="asbchj"; //immutable
            Console.WriteLine(p2);
        }
    }
 }