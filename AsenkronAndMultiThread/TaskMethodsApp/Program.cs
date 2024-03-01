using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMethodsApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // ContinueWith: Triggers another action when a task is completed. Used in asynchronous operations, does not block.
            Task task1 = Task.Run(() =>
            {
                // Simulation of a heavy operation
            }).ContinueWith(previousTask =>
            {
                // Code block that runs after the previous task is completed
            });

            // WhenAll: Waits for all given tasks to complete. Used in asynchronous operations, does not block.
            Task allTasks = Task.WhenAll(
                Task.Run(() => { /* Operation 1 */ }),
                Task.Run(() => { /* Operation 2 */ })
            );
            // Waits for completion, main thread does not block.
            await allTasks;

            // WhenAny: Waits for any of the given tasks to complete. Used in asynchronous operations, does not block.
            Task<int> anyTask = Task.WhenAny(
                Task.Run(() =>
                {
                    // Operation 1
                    return 1;
                }),
                Task.Run(() =>
                {
                    // Operation 2
                    return 2;
                })
            ).Result; // Result of the first completed task

            // WaitAll: Waits for all given tasks to complete. Used in synchronous operations, blocks the calling thread.
            Task.WaitAll(
                Task.Run(() => { /* Operation 1 */ }),
                Task.Run(() => { /* Operation 2 */ })
            );

            // WaitAny: Waits for any of the given tasks to complete. Used in synchronous operations, blocks the calling thread.
            Task.WaitAny(
                Task.Run(() => { /* Operation 1 */ }),
                Task.Run(() => { /* Operation 2 */ })
            );

            // Delay: Waits for a specified amount of time. Used in asynchronous operations, does not block.
            await Task.Delay(1000); // Waits for 1 second

            // Run: Starts a new task and ensures it runs asynchronously. Does not block.
            await Task.Run(() =>
            {
                // Simulation of a heavy operation
            });

            // StartNew: Starts a new task. Similar to Task.Run but offers more detailed options. Used in asynchronous operations, does not block.
            Task<int> taskWithStartNew = Task.Factory.StartNew(() => 42, TaskCreationOptions.LongRunning);
            // TaskCreationOptions.LongRunning indicates that the task could run for a long time.

            // FromResult: Used to return a ready value as a Task. Returns the result immediately without doing any operation, does not block.
            Task<int> taskFromResult = Task.FromResult(42);

            Console.WriteLine($"Result of the task completed with WhenAny: {await anyTask}");
            Console.WriteLine($"Result of the task created with FromResult: {await taskFromResult}");

            // Task.CompletedTask: Used when no value needs to be returned.
            await Task.CompletedTask;
        }




        
    }
}
