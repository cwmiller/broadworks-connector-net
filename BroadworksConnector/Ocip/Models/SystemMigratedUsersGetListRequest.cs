using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of migrated users.
    /// The response is either SystemMigratedUsersGetListResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemMigratedUsersGetListRequest22 in AS data mode
    /// <see cref="SystemMigratedUsersGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemMigratedUsersGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27750""}]")]
    public class SystemMigratedUsersGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMigratedUsersGetListResponse>
    {

    }
}
