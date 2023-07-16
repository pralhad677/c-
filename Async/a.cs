//  async Task<int> getAge(){
//   Console.WriteLine("before Task.run ");
//   Console.WriteLine($"in getAge before:{Thread.CurrentThread.ManagedThreadId}");
//   await Task.Run(async ()=>{

//   Console.WriteLine("inside Task.run ");
//   Console.WriteLine($"inside of Task.Run:{Thread.CurrentThread.ManagedThreadId}");
//    await   Task.Delay(5000);
//   });
//   Console.WriteLine("after Task.run ");
  
//   Console.WriteLine($"intAge after:{Thread.CurrentThread.ManagedThreadId}");
//   return 3;
//  }

//  async Task<string> A(){
//   // int data =  getAge().GetAwaiter().GetResult(); //synchronous
//   int data = await getAge(); //async
//  string result = data switch{
//     int x when x==1 =>"one",
//     int x when x==2 =>"two",
//     _ =>"not one or two"
//  };
//  return result;
//  }

//  string data =await   A();
//  Console.WriteLine(data);