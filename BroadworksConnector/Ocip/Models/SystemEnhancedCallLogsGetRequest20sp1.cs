using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs.
    /// The response is either a SystemEnhancedCallLogsGetResponse20sp1 or an ErrorResponse.
    /// Replaced by:SystemEnhancedCallLogsGetRequest22 in AS data mode
    /// <see cref="SystemEnhancedCallLogsGetResponse20sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemEnhancedCallLogsGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26884""}]")]
    public class SystemEnhancedCallLogsGetRequest20sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsGetResponse20sp1>
    {

    }
}
