using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get list of default Feature Access Codes defined on system
    /// level.
    /// The response is either SystemFeatureAccessCodeGetListResponse20 or
    /// ErrorResponse.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by: SystemFeatureAccessCodeGetListRequest21
    /// <see cref="SystemFeatureAccessCodeGetListResponse20"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemFeatureAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26763""}]")]
    public class SystemFeatureAccessCodeGetListRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemFeatureAccessCodeGetListResponse20>
    {

    }
}
