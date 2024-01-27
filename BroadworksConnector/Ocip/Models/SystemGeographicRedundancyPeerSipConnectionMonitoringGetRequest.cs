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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10623""}]")]
    public class SystemGeographicRedundancyPeerSipConnectionMonitoringGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGeographicRedundancyPeerSipConnectionMonitoringGetResponse>
    {

    }
}
