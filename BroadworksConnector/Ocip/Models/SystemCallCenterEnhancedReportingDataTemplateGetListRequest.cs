using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of data template and the corresponding information in the system.
    /// The response is either a SystemCallCenterEnhancedReportingDataTemplateGetListResponse or an ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingDataTemplateGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6016""}]")]
    public class SystemCallCenterEnhancedReportingDataTemplateGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterEnhancedReportingDataTemplateGetListResponse>
    {

    }
}
