using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system branding information.
    /// The response is either SystemCallCenterEnhancedReportingBrandingGetResponse or ErrorResponse.
    /// <see cref="SystemCallCenterEnhancedReportingBrandingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5973""}]")]
    public class SystemCallCenterEnhancedReportingBrandingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
