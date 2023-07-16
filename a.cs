namespace Jacob{
    public class Person{
       private string[] list = new string[10];

        public string this[int index]
        {
       get
        {
            // return value of stored at studentName array  
            return list[index];
        }

        set
        {
            // assigns value to studentName  
            list[index] = value;
        }
        }
    }
}