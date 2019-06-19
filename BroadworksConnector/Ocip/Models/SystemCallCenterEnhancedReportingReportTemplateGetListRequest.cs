using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get system level call center report template list.
    /// The response is either a SystemCallCenterEnhancedReportingReportTemplateGetListResponse or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingReportTemplateGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6184""}]")]
    public class SystemCallCenterEnhancedReportingReportTemplateGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
