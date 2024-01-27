using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's DNIS Announcements
    /// The response is either a GroupCallCenterGetDNISAnnouncementResponse or an ErrorResponse.
    /// 
    /// Replaced by GroupCallCenterGetDNISAnnouncementRequest17sp4
    /// <see cref="GroupCallCenterGetDNISAnnouncementResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterGetDNISAnnouncementRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:5482""}]")]
    public class GroupCallCenterGetDNISAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupCallCenterGetDNISAnnouncementResponse>
    {

        protected BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:5482")]
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
