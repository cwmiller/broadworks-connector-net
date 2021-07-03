using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the hPBX mobile termination related configuration parameters.
    /// The response is either a SystemHPBXMobileTerminationGetResponse or an ErrorResponse.
    /// <see cref="SystemHPBXMobileTerminationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11361""}]")]
    public class SystemHPBXMobileTerminationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
