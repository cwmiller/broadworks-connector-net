using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's DNIS Announcements
    /// The response is either a GroupCallCenterGetDNISAnnouncementResponse17sp4 or an ErrorResponse.
    /// 
    /// Replaced by: GroupCallCenterGetDNISAnnouncementRequest19.
    /// <see cref="GroupCallCenterGetDNISAnnouncementResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterGetDNISAnnouncementRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:5500""}]")]
    public class GroupCallCenterGetDNISAnnouncementRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetDNISAnnouncementResponse17sp4>
    {

        protected BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5500")]
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
