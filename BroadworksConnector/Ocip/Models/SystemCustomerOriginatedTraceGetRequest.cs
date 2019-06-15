using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Customer Originated Trace.
    /// The response is either a SystemCustomerOriginatedTraceGetResponse or an
    /// ErrorResponse.
        /// <see cref="SystemCustomerOriginatedTraceGetResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCustomerOriginatedTraceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
    }
}
