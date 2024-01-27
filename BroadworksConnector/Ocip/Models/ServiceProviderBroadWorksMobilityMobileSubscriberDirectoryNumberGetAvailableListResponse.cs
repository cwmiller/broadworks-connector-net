using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest.
    /// Contains a list of available Mobile Subscriber Directory Numbers not yet assigned to any group.
    /// <see cref="ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:593""}]")]
    public class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _availableMobileSubscriberDirectoryNumber = new List<string>();

        [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:593")]
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
