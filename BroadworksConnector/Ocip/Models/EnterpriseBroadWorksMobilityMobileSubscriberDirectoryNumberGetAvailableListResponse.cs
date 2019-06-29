using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest.
    /// Contains a list of available Mobile Subscriber Directory Numbers not yet assigned to any user.
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:222""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _availableMobileSubscriberDirectoryNumber = new List<string>();

        [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f7ae3539fd471e995b07dc1bf8836e2d:222")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> AvailableMobileSubscriberDirectoryNumber
        {
            get => _availableMobileSubscriberDirectoryNumber;
            set
            {
                AvailableMobileSubscriberDirectoryNumberSpecified = true;
                _availableMobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableMobileSubscriberDirectoryNumberSpecified { get; set; }

    }
}
