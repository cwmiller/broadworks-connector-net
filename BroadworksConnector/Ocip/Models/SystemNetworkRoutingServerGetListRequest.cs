using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of routing Network Servers defined in the system.
    /// The response is either a SystemNetworkRoutingServerGetListResponse or an ErrorResponse.
    /// <see cref="SystemNetworkRoutingServerGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12733""}]")]
    public class SystemNetworkRoutingServerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNetworkRoutingServerGetListResponse>
    {

    }
}
