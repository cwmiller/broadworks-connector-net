using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the SMDI access control list.
    /// The response is either SystemSMDIGetACLListResponse or ErrorResponse.
    /// <see cref="SystemSMDIGetACLListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17655""}]")]
    public class SystemSMDIGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
