using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request a summary table of all System Service DNs.
    /// The response is either SystemSystemServiceDnGetSummaryListResponse or ErrorResponse.
    /// <see cref="SystemSystemServiceDnGetSummaryListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18264""}]")]
    public class SystemSystemServiceDnGetSummaryListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
