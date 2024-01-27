using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Enhanced Call Logs.
    /// The response is either a SystemEnhancedCallLogsGetResponse22 or ErrorResponse
    /// Replaced by: SystemEnhancedCallLogsGetRequest24.
    /// Response to SystemDeviceTypeGetRequest16sp1.
    /// <see cref="SystemEnhancedCallLogsGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemEnhancedCallLogsGetRequest24"/>
    /// <see cref="SystemDeviceTypeGetRequest16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:26900""}]")]
    public class SystemEnhancedCallLogsGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemEnhancedCallLogsGetResponse22>
    {

    }
}
