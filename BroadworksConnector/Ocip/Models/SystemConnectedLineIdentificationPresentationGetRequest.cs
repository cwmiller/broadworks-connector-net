using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the COLP service.
    /// The response is either a SystemConnectedLineIdentificationPresentationGetResponse or an
    /// ErrorResponse.
    /// <see cref="SystemConnectedLineIdentificationPresentationGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2ea11c5e213a79b17d4a363684d76c57:44""}]")]
    public class SystemConnectedLineIdentificationPresentationGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
