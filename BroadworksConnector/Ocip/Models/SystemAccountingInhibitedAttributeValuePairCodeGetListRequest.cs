using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of Attribute Value Pair (AVP) combinations that are
    /// disabled.
    /// The response is either a SystemAccountingInhibitedAttributeValuePairCodeGetListResponse or an ErrorResponse.
    /// <see cref="SystemAccountingInhibitedAttributeValuePairCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2026""}]")]
    public class SystemAccountingInhibitedAttributeValuePairCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccountingInhibitedAttributeValuePairCodeGetListResponse>
    {

    }
}
