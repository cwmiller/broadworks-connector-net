using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""55636b88804490cf0ead7c9d4f44f28d:44""}]")]
    public class SystemCustomerOriginatedTraceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
