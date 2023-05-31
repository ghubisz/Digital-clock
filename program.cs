using System;

class Program
{
    static void Main()
    {
        //Run the clock continuosly
        while(true)
        {
            //Clear the console for the updated time
            Console.Clear();

            //Get the current time
            DateTime currentTime = DateTime.Now;

            //Format the time as HH:mm:ss
            string formatedTime = currentTime.ToString("HH:mm:ss");

            //Display the time in the console
            Console.WriteLine(formatedTime);

            //Wait for 1 second before updating again
            System.Threading.Thread.Sleep(1000);
        }
    }
}
