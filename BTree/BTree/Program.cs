using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Xml;
using System.Net;
using System.IO;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security.Permissions;
namespace BTree
{  
    class Program
    {
        //    [DllImport("eib7.dll")]
        //  public static extern bool EIB7InitAxis(string ip,long abc);
        [SecurityPermission(SecurityAction.Demand)]
        static void Main(string[] args)
        {

            //NetTcpBinding binding = new NetTcpBinding();
            //EndpointAddress address = new EndpointAddress(@"tcp://blwdsup1.cfs.betasys.com:9100/t1linkapiservermanager/t1linkapiuri");

            //Use NetTcp binding

            //string _url = "tcp://blwdsup1.cfs.betasys.com:9100/t1linkapiservermanager/t1linkapiuri";
            //var _action = "GetXMLData";

            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            //HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            //InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            //// begin async call to web request.
            //IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            //// suspend this thread until call is complete. You might want to
            //// do something usefull here like update your UI.
            //asyncResult.AsyncWaitHandle.WaitOne();

            //// get the response from the completed web request.
            //string soapResult;
            //using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            //{
            //    using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
            //    {
            //        soapResult = rd.ReadToEnd();
            //    }
            //    Console.Write(soapResult);
            //}
        
        
       
            // Create the channel.
            TcpChannel clientChannel = new TcpChannel();

            // Register the channel.
            ChannelServices.RegisterChannel(clientChannel, false);

            // Register as client for remote object.
            WellKnownClientTypeEntry remoteType = new WellKnownClientTypeEntry(
                typeof(RemoteObject), "tcp://blwdsup1.cfs.betasys.com:9100/t1linkapiservermanager/t1linkapiuri");
            RemotingConfiguration.RegisterWellKnownClientType(remoteType);

            // Create a message sink.
            string objectUri;
            System.Runtime.Remoting.Messaging.IMessageSink messageSink =
                clientChannel.CreateMessageSink(
                    "tcp://blwdsup1.cfs.betasys.com:9100/t1linkapiservermanager/t1linkapiuri", null,
                    out objectUri);
            Console.WriteLine("The URI of the message sink is {0}.",
                objectUri);
            if (messageSink != null)
            {
                Console.WriteLine("The type of the message sink is {0}.",
                    messageSink.GetType().ToString());
            }

            // Create an instance of the remote object.
            RemoteObject service = new RemoteObject();

            // Invoke a method on the remote object.
            Console.WriteLine("The client is invoking the remote object.");
            Console.WriteLine("The remote object has been called {0} times.",
                service.GetCount());
            Console.ReadLine();
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(@"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/1999/XMLSchema""><SOAP-ENV:Body><HelloWorld xmlns=""http://tempuri.org/"" SOAP-ENV:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/""><int1 xsi:type=""xsd:integer"">12</int1><int2 xsi:type=""xsd:integer"">32</int2></HelloWorld></SOAP-ENV:Body></SOAP-ENV:Envelope>");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

        //Console.WriteLine(string.Format("{0:#,0.00}","160450"));

        //try
        //{
        //    EIB7InitAxis();
        //}
        //catch (Exception ex)
        //{

        //    +Console.WriteLine(ex.Message);
        //}


        //string str = "-14494822.74";
        //    Console.WriteLine(double.Parse(str));
        //    Console.Read();
        //    //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    //BTree bTree = new BTree() { value = 0 };
        //    //for (int i = 0; i < array.Length; i++)
        //    //{
        //    //    AddNode(array[i], bTree);
        //    //}
    }

        //private static void AddNode(int val, BTree bTree)
        //{
        //    if (bTree.value > val)
        //    {
        //        bTree.Left = new BTree { value = val };
        //    }

        //    if(bTree.value<=val)
        //    {
        //        bTree.Right = new BTree { value = val };
        //    }
        //}
    }
    //public class BTree
    //{
    //    public BTree Left { get; set; }
    //    public BTree Right { get; set; }
    //    public int value { get; set; }
    //}


