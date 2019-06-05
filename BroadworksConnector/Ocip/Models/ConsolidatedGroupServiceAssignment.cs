using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class ConsolidatedGroupServiceAssignment
    {
        private BroadworksConnector.Ocip.Models.GroupService _groupServiceName;

        [XmlElement(ElementName = "groupServiceName", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupService GroupServiceName
        {
            get => _groupServiceName;
            set
            {
                GroupServiceNameSpecified = true;
                _groupServiceName = value;
            }
        }

        [XmlIgnore]
        public bool GroupServiceNameSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity
        {
            get => _authorizedQuantity;
            set
            {
                AuthorizedQuantitySpecified = true;
                _authorizedQuantity = value;
            }
        }

        [XmlIgnore]
        public bool AuthorizedQuantitySpecified { get; set; }
    }
}
