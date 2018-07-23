using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfMessageContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorService : ICalculatorService
    {
        // Perform a calculation.  

        public MyMessage Calculate(MyMessage request)
        {
            MyMessage response = new MyMessage(request);
            switch (request.Operation)
            {
                case "+":
                    response.Result = request.N1 + request.N2;
                    break;
                case "-":
                    response.Result = request.N1 - request.N2;
                    break;
                case "*":
                    response.Result = request.N1 * request.N2;
                    break;
                case "/":
                    response.Result = request.N1 / request.N2;
                    break;
                default:
                    response.Result = 0.0D;
                    break;
            }
            return response;
        }
    }
}
