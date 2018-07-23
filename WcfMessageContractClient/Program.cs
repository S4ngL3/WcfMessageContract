using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfMessageContractClient.Calculator;

namespace WcfMessageContractClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a client.  

            CalculatorServiceClient client = new CalculatorServiceClient();

            // Perform addition using a typed message.  

            MyMessage request = new MyMessage();
            request.N1 = 100D;
            request.N2 = 15.99D;
            request.Operation = "+";
            MyMessage response = ((ICalculatorService)client).Calculate(request);
            Console.WriteLine("Add({0},{1}) = {2}", request.N1, request.N2, response.Result);

            //Closing the client releases all communication resources.  
            client.Close();
            Console.ReadLine();
        }
    }
}
