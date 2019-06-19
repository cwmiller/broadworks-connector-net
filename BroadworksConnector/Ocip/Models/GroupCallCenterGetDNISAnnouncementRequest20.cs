using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a call center's DNIS Announcements
    /// The response is either a GroupCallCenterGetDNISAnnouncementResponse20 or an ErrorResponse.
    /// <see cref="GroupCallCenterGetDNISAnnouncementResponse20"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4331""}]")]
    public class GroupCallCenterGetDNISAnnouncementRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.DNISKey _dnisKey;

        [XmlElement(ElementName = "dnisKey", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4331")]
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
        public bool DnisKeySpecified { get; set; }

    }
}
