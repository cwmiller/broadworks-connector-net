using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of Peer SIP Connection system parameters
    /// The response is a SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse.
    /// <see cref="SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10505""}]")]
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
