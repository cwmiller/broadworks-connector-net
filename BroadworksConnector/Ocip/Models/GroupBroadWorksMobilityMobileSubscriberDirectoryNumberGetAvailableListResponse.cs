using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest.
    /// Contains a list of available Mobile Subscriber Directory Numbers not yet assigned to any user.
    /// <see cref="GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:432""}]")]
    public class GroupBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _mobileSubscriberDirectoryNumber = new List<string>();

        [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:432")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> MobileSubscriberDirectoryNumber
        {
            get => _mobileSubscriberDirectoryNumber;
            set
            {
                MobileSubscriberDirectoryNumberSpecified = true;
                _mobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MobileSubscriberDirectoryNumberSpecified { get; set; }

    }
}
