namespace Overload{

    public class Jacob1{
        public  string name="jacob";

        

        public string getName(ref string name){
            name="ryan";
            return name;
        }
        public string GetJacob(Jacob1 j){
            j.name = "hunter";
            return j.name;
        }

        public void getAge(out int age){
            age=35;
        }

        public int[] getList(params int[] data){
            return data;
        }
    }
}