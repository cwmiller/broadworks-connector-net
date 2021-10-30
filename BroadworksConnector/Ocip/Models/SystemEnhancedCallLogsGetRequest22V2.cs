using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs. The response is either a SystemEnhancedCallLogsGetResponse22V2 or an ErrorResponse.
    /// <see cref="SystemEnhancedCallLogsGetResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:236""}]")]
    public class SystemEnhancedCallLogsGetRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsGetResponse22V2>
    {

    }
}
