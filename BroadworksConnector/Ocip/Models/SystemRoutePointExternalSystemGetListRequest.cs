using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Route Point External Systems that are configured for the system.
    /// The response is either SystemRoutePointExternalSystemGetListResponse or ErrorResponse.
    /// <see cref="SystemRoutePointExternalSystemGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14027""}]")]
    public class SystemRoutePointExternalSystemGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
