using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the list of file repositories in the system.
    /// The response is either a SystemFileRepositoryDeviceGetListResponse or an ErrorResponse.
    /// <see cref="SystemFileRepositoryDeviceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10290""}]")]
    public class SystemFileRepositoryDeviceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
