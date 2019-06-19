using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of users that are unreachable from the primary application server.
    /// The response is a SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22 in AS data mode
    /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38732""}]")]
    public class SystemGeographicRedundancyUnreachableFromPrimaryGetUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
