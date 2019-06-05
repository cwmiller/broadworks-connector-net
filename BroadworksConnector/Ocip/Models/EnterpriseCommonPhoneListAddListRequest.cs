using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseCommonPhoneListAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.PhoneListEntry> _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.PhoneListEntry> Entry
        {
            get => _entry;
            set
            {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        public bool EntrySpecified { get; set; }
    }
}
