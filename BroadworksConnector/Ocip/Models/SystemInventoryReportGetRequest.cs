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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d9fdc459bf0815ec7de2752c27ed25dd:81""}]")]
    public class SystemInventoryReportGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemInventoryReportGetResponse>
    {

    }
}
