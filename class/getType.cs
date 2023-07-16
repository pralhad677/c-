namespace GetType1 {
    public class GetType12{
        public readonly string name;
        public GetType12(string name1){
            this.name = name1;
        }
    }
    public class P:GetType12{
        public P(string p):base(p){}
    }
}