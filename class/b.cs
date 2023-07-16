namespace switch1{
    public class Person{
        public static int age= 25;

        public int getAge(){
            return Person.age switch 
            {
                1=>25,
                2=>35,
                25=>120,
                _=>throw new Exception("asd")
            };
        }
    }
}