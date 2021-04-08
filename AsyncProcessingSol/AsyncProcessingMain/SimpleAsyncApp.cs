using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;



namespace AsyncProcessingMain
{



    public class SimpleAsyncApp
    {


        //public void Run()
        async public void Run()
        //async public Task Run()
        {
            Console.WriteLine("Hi here!");
            //int intValue = await GetIntValueAsync();
            //string stringValue = await GetStringValueAsync();
            //Console.WriteLine(await GetIntValueAsync());
            //Console.WriteLine(await GetStringValueAsync());
            //Console.WriteLine(await GetIntValueAsync());
            //Console.WriteLine(await GetStringValueAsync());
            Task<int> intValueTask = GetIntValueAsync();
            Task<string> stringValueTask = GetStringValueAsync();
            //int intValue = await intValueTask;
            //string stringValue = await stringValueTask;
            //Console.WriteLine(intValue);
            //Console.WriteLine(stringValue);
            //IList<Task> tasks = new List<Task> { intValueTask, stringValueTask };
            //IList<Task<object>> tasks = new List<Task<object>> { intValueTask, stringValueTask };
            //foreach (Task<object> task in tasks)
            //{
            //    await DisplayValueAsync(task);
            //}
            //await DisplayValueAsync<int>(intValueTask);
            //await DisplayValueAsync<string>(stringValueTask);
            Task displayIntTask = DisplayValueAsync<int>(intValueTask);
            Task displayStringTask = DisplayValueAsync<string>(stringValueTask);


            await displayIntTask;
            await displayStringTask;
            Console.WriteLine("Hi there!");
        }



        async public Task DisplayValueAsync<T>(Task<T> valueTask)
        {
            T value = await valueTask;
            Console.WriteLine(value);
        }
        //async public Task DisplayValueAsync(Task<object> valueTask)
        //{
        //    object value = await valueTask;
        //    Console.WriteLine(value);
        //}



        //public Task<int> GetIntValueAsync()
        async public Task<int> GetIntValueAsync()
        {
            Console.WriteLine("Before Task.Delay(2000)...");
            await Task.Delay(2000);
            //Task.Delay(2000).Wait();
            Console.WriteLine("After Task.Delay(2000)...");
            return 10;
        }



        async public Task<string> GetStringValueAsync()
        {
            Console.WriteLine("Before Task.Delay(1000)...");
            await Task.Delay(1000);
            //Task.Delay(1000).Wait();
            Console.WriteLine("After Task.Delay(1000)...");
            return "Hello";
        }



        //public Task<int> GetIntValueAsync()
        //{
        //    //return await Task.Run<int>(() =>
        //    //{
        //    //    //Thread.Sleep(2000);
        //    //    Task.Delay(2000).Wait();
        //    //    return 10;
        //    //});
        //    return new Task<int>(() => { Task.Delay(2000).Wait(); return 10; });
        //    //Task.Delay(2000).Wait();
        //    //return 10;
        //}



        //public Task<string> GetStringValueAsync()
        //{
        //    //return await Task.Run<string>(() =>
        //    //{
        //    //    //Thread.Sleep(2000);
        //    //    Task.Delay(1000).Wait();
        //    //    return "Hello";
        //    //});
        //    return new Task<string>(() => { Task.Delay(1000).Wait(); return "Hello"; });
        //    //Task.Delay(1000).Wait();
        //    //return "Hello";
        //}



        //async public Task<int> GetIntValueAsync()
        //{
        //    //return await Task.Run<int>(() =>
        //    //{
        //    //    //Thread.Sleep(2000);
        //    //    Task.Delay(2000).Wait();
        //    //    return 10;
        //    //});
        //    //return new Task<int>(() => { Task.Delay(2000).Wait(); return 10; });
        //    Task.Delay(2000).Wait();
        //    return 10;
        //}



        //async public Task<string> GetStringValueAsync()
        //{
        //    //return await Task.Run<string>(() =>
        //    //{
        //    //    //Thread.Sleep(2000);
        //    //    Task.Delay(1000).Wait();
        //    //    return "Hello";
        //    //});
        //    Task.Delay(1000).Wait();
        //    return "Hello";
        //}



    }



}
