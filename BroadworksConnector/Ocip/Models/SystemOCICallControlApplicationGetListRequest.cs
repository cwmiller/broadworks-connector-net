using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the OCI call control application list.
    /// The response is either SystemOCICallControlApplicationGetListResponse or ErrorResponse.
    /// <see cref="SystemOCICallControlApplicationGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13456""}]")]
    public class SystemOCICallControlApplicationGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
