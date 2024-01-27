using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the call center enhanced reporting system settings.
    /// The response is either a SystemCallCenterEnhancedReportingGetResponse or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6045""}]")]
    public class SystemCallCenterEnhancedReportingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingGetResponse>
    {

    }
}
