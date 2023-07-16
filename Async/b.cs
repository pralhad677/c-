// async Task<int> getNumber(){
//   await Task.Run(()=>{

//   });
//   return 4;
// }

// Task<int> task1 = Task.Run(async () => {
//   return await getNumber();
//   }
//   );
// Task<int> task2 = task1.ContinueWith(previousTask => previousTask.Result * 2);
// Task<int> task3 = task2.ContinueWith(previousTask => previousTask.Result * 2);

// Console.WriteLine("Result of task1: " + task1.Result);
// Console.WriteLine("Result of task2: " + task2.Result);
// Console.WriteLine("Result of task2: " + task3.Result);
