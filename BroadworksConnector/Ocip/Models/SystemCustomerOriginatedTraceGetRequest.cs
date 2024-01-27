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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b879060a029bc884d4ec2c341a2783f:44""}]")]
    public class SystemCustomerOriginatedTraceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCustomerOriginatedTraceGetResponse>
    {

    }
}
