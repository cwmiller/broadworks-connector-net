using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of user creation tasks in the system.
    /// The response is either SystemTrunkGroupUserCreationTaskGetListResponse or ErrorResponse.
    /// <see cref="SystemTrunkGroupUserCreationTaskGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:6649""}]")]
    public class SystemTrunkGroupUserCreationTaskGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
