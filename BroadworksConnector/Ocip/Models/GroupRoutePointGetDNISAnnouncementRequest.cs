using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a route point's DNIS Announcements
    /// The response is either a GroupRoutePointGetDNISAnnouncementResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupRoutePointGetDNISAnnouncementRequest19.
    /// <see cref="GroupRoutePointGetDNISAnnouncementResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupRoutePointGetDNISAnnouncementRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:12464""}]")]
    public class GroupRoutePointGetDNISAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupRoutePointGetDNISAnnouncementResponse>
    {

        protected BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12464")]
        public BroadWorksConnector.Ocip.Models.DNISKey DnisKey
        {
            get => _dnisKey;
            set
            {
                DnisKeySpecified = true;
                _dnisKey = value;
            }
        }

        [XmlIgnore]
        protected bool DnisKeySpecified { get; set; }

    }
}
