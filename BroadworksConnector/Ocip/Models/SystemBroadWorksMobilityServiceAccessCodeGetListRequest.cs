using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of system service access codes.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeGetListResponse or ErrorResponse.
    /// Replaced by SystemBroadWorksMobilityServiceAccessCodeGetListRequest21.
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeGetListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21245""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobilityServiceAccessCodeGetListResponse>
    {

    }
}
