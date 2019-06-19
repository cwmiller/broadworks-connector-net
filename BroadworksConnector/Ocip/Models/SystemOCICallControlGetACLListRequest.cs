using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI call control access control list.
    /// The response is either SystemOCICallControlGetACLListResponse or ErrorResponse.
    /// <see cref="SystemOCICallControlGetACLListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12415""}]")]
    public class SystemOCICallControlGetACLListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
