using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of System Diameter base parameters.
    /// The response is either SystemBwDiameterBaseDataGetResponse17sp3 or ErrorResponse.
    /// <see cref="SystemBwDiameterBaseDataGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21339""}]")]
    public class SystemBwDiameterBaseDataGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBwDiameterBaseDataGetResponse17sp3>
    {

    }
}
