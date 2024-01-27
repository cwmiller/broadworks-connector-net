using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of user creation tasks in the system.
    /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse14sp4 or ErrorResponse.
    /// <see cref="SystemTrunkGroupUserCreationTaskGetListResponse14sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1871""}]")]
    public class SystemTrunkGroupUserCreationTaskGetListRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTrunkGroupUserCreationTaskGetListResponse14sp4>
    {

    }
}
