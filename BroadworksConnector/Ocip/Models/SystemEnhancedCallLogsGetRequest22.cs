using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs. The response is either a SystemEnhancedCallLogsGetResponse22 or an ErrorResponse.
    /// <see cref="SystemEnhancedCallLogsGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:197""}]")]
    public class SystemEnhancedCallLogsGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
