using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of Diameter routing peers associated with the specified realm. The response is either SystemBwDiameterRoutingPeerGetListResponse or  ErrorResponse.
    /// <see cref="SystemBwDiameterRoutingPeerGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2483""}]")]
    public class SystemBwDiameterRoutingPeerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
