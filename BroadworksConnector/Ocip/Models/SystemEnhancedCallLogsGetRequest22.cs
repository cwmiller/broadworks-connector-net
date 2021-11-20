using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs.
    /// Replaced by: SystemEnhancedCallLogsGetRequest24.
    /// The response is either a SystemEnhancedCallLogsGetResponse22 or an ErrorResponse.
    /// <see cref="SystemEnhancedCallLogsGetRequest24"/>
    /// <see cref="SystemEnhancedCallLogsGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26489""}]")]
    public class SystemEnhancedCallLogsGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsGetResponse22>
    {

    }
}
