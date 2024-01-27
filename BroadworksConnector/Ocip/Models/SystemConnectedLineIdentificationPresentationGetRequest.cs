using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the COLP service.
    /// The response is either a SystemConnectedLineIdentificationPresentationGetResponse or an ErrorResponse.
    /// <see cref="SystemConnectedLineIdentificationPresentationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2256aa4d4c7d3679ce18e4f471895147:43""}]")]
    public class SystemConnectedLineIdentificationPresentationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemConnectedLineIdentificationPresentationGetResponse>
    {

    }
}
