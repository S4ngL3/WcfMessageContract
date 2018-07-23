using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfMessageContract
{
    [MessageContract]
    public class MyMessage
    {
        private string operation;
        private double n1;
        private double n2;
        private double result;

        //Constructor - create an empty message.  

        public MyMessage() { }

        //Constructor - create a message and populate its members.  

        public MyMessage(double n1, double n2, string operation,
                         double result)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.operation = operation;
            this.result = result;
        }

        //Constructor - create a message from another message.  

        public MyMessage(MyMessage message)
        {
            this.n1 = message.n1;
            this.n2 = message.n2;
            this.operation = message.operation;
            this.result = message.result;
        }

        [MessageHeader]
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        [MessageBodyMember]
        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }

        [MessageBodyMember]
        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        [MessageBodyMember]
        public double Result
        {
            get { return result; }
            set { result = value; }
        }
    }
}