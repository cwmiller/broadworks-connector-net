using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the ordered list of supported codecs in the system.
    /// The ordered list of codecs is sent to MGCP devices when creating connections.
    /// The response is either a SystemCodecGetListResponse or an ErrorResponse.
    /// <see cref="SystemCodecGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5507""}]")]
    public class SystemCodecGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
