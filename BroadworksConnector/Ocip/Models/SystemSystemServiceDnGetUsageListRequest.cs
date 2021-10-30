using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a list of System Service DN utilization.
    /// The response is either SystemSystemServiceDnGetUsageListResponse or ErrorResponse.
    /// <see cref="SystemSystemServiceDnGetUsageListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18295""}]")]
    public class SystemSystemServiceDnGetUsageListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSystemServiceDnGetUsageListResponse>
    {

    }
}
