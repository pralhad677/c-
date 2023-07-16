namespace Multi{
    interface IAnimal {
   void Move();
}

interface IReptile {
   void Swim();
}

class Turtle : IAnimal, IReptile {
   public void Move() {
      Console.WriteLine("Turtle is crawling.");
   }
   
   public void Swim() {
      Console.WriteLine("Turtle is swimming.");
   }
}

}