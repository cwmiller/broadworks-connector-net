using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Call Center Event Recording File system parameters.
    /// The response is either SystemCallCenterEventRecordingFileParametersGetResponse or ErrorResponse.
    /// <see cref="SystemCallCenterEventRecordingFileParametersGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:6474""}]")]
    public class SystemCallCenterEventRecordingFileParametersGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
