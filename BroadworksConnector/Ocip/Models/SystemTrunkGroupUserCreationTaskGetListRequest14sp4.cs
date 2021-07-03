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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1872""}]")]
    public class SystemTrunkGroupUserCreationTaskGetListRequest14sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
