using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs.
    /// The response is either a SystemEnhancedCallLogsGetResponse17sp4 or an ErrorResponse.
    /// Replaced by:SystemEnhancedCallLogsGetRequest20sp1 in AS data mode
    /// <see cref="SystemEnhancedCallLogsGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemEnhancedCallLogsGetRequest20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26869""}]")]
    public class SystemEnhancedCallLogsGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsGetResponse17sp4>
    {

    }
}
