using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of Service Access Code lists.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeListGetListResponse or ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeListGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:1381""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeListGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemBroadWorksMobilityServiceAccessCodeListGetListResponse>
    {

    }
}
