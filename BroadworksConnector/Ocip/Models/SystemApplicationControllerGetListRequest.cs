using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of application controllers that are configured for the system.
    /// The response is either SystemApplicationControllerGetListResponse or ErrorResponse.
    /// <see cref="SystemApplicationControllerGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2347""}]")]
    public class SystemApplicationControllerGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
