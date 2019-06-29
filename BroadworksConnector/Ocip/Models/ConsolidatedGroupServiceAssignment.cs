using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Authorize and assign a group service.
    /// 
    /// The authorizedQuantity will be used at the group level if provided; otherwise, the service quantity will be set to unlimited.
    /// The command will fail if the authorized quantity set at the service provider level is insufficient.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1542""}]")]
    public class ConsolidatedGroupServiceAssignment
    {

        private BroadWorksConnector.Ocip.Models.GroupService _groupServiceName;

        [XmlElement(ElementName = "groupServiceName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1542")]
        public BroadWorksConnector.Ocip.Models.GroupService GroupServiceName
        {
            get => _groupServiceName;
            set
            {
                GroupServiceNameSpecified = true;
                _groupServiceName = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UnboundedPositiveInt _authorizedQuantity;

        [XmlElement(ElementName = "authorizedQuantity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1542")]
        public BroadWorksConnector.Ocip.Models.UnboundedPositiveInt AuthorizedQuantity
        {
            get => _authorizedQuantity;
            set
            {
                AuthorizedQuantitySpecified = true;
                _authorizedQuantity = value;
            }
        }

        [XmlIgnore]
        protected bool AuthorizedQuantitySpecified { get; set; }

    }
}
