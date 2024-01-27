using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Radius Servers defined in the system.
    /// The response is either a SystemAccountingGetRadiusServerListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemAccountingGetRadiusServerListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1960""}]")]
    public class SystemAccountingGetRadiusServerListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemAccountingGetRadiusServerListResponse>
    {

    }
}
