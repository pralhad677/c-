//  TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();

//  Task<int> task = tcs.Task;

//  var awaiter  = task.GetAwaiter();

//  awaiter.OnCompleted(()=>{
//   int result = awaiter.GetResult();
//   Console.WriteLine(result);
//  });

//  tcs.SetResult(5);