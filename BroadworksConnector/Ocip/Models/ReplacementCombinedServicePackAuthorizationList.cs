using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of service packs that replaces previously authorized service packs.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3158""}]")]
    public class ReplacementCombinedServicePackAuthorizationList
    {

        private List<BroadWorksConnector.Ocip.Models.CombinedServicePackAuthorization> _servicePackAuthorization = new List<BroadWorksConnector.Ocip.Models.CombinedServicePackAuthorization>();

        [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3158")]
        public List<BroadWorksConnector.Ocip.Models.CombinedServicePackAuthorization> ServicePackAuthorization
        {
            get => _servicePackAuthorization;
            set
            {
                ServicePackAuthorizationSpecified = true;
                _servicePackAuthorization = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackAuthorizationSpecified { get; set; }

    }
}
