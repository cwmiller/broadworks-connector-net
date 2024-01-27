using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of system level successful SIP OPTIONS message respoonse status codes.
    /// The response is either SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse or ErrorResponse.
    /// <see cref="SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1841""}]")]
    public class SystemTrunkGroupOptionsMessageResponseStatusCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTrunkGroupOptionsMessageResponseStatusCodeGetListResponse>
    {

    }
}
