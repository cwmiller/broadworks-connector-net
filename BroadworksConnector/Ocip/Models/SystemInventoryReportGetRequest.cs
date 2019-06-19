using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Inventory Report.
    /// The response is either a SystemInventoryReportGetResponse or an
    /// ErrorResponse.
    /// <see cref="SystemInventoryReportGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5c0fc3a03773b4f430e938115770c82d:81""}]")]
    public class SystemInventoryReportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
