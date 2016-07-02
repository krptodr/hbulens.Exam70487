﻿using hbulens.Exam70487.Common;
using hbulens.Exam70487.Wcf.Behaviors.Contract;
using hbulens.Exam70487.Wcf.Inspectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace hbulens.Exam70487.Wcf
{
    [ServiceContract(Namespace = "https://github.com/hbulens/Exam70487")]
    public interface ICustomerService
    {
        #region Request-Reply

        [MyOperationBehavior]
        [OperationContract]
        [MyContractBehavior]    
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)] // REST support
        IEnumerable<Customer> Get();

        #endregion Request-Reply

        #region One-Way
     
        [OperationContract(IsOneWay = true)]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)] // REST support
        void SaveChanges();

        #endregion One-Way        
    }
}
