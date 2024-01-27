using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with the Trunk Group service.
    /// The response is either SystemTrunkGroupGetResponse21 or ErrorResponse.
    /// 
    /// Replaced by: SystemTrunkGroupGetRequest22
    /// <see cref="SystemTrunkGroupGetResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemTrunkGroupGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:36518""}]")]
    public class SystemTrunkGroupGetRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemTrunkGroupGetResponse21>
    {

    }
}
