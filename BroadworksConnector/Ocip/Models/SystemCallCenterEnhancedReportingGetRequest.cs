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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6049""}]")]
    public class SystemCallCenterEnhancedReportingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
