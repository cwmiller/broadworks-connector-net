using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Network Classes of Service.
    /// The response is either a SystemNetworkClassOfServiceGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemNetworkClassOfServiceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12492""}]")]
    public class SystemNetworkClassOfServiceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemNetworkClassOfServiceGetListResponse>
    {

    }
}
