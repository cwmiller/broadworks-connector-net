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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4262""}]")]
    public class ReplacementCombinedServicePackAuthorizationList
    {

        protected List<BroadWorksConnector.Ocip.Models.CombinedServicePackAuthorization> _servicePackAuthorization = new List<BroadWorksConnector.Ocip.Models.CombinedServicePackAuthorization>();

        [XmlElement(ElementName = "servicePackAuthorization", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4262")]
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
        protected bool ServicePackAuthorizationSpecified { get; set; }

    }
}
