using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of group services that replaces a previously authorized group services.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3738""}]")]
    public class ReplacementCombinedGroupServiceAuthorizationList
    {

        private List<BroadWorksConnector.Ocip.Models.CombinedGroupServiceAuthorization> _groupServiceAuthorization = new List<BroadWorksConnector.Ocip.Models.CombinedGroupServiceAuthorization>();

        [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3738")]
        public List<BroadWorksConnector.Ocip.Models.CombinedGroupServiceAuthorization> GroupServiceAuthorization
        {
            get => _groupServiceAuthorization;
            set
            {
                GroupServiceAuthorizationSpecified = true;
                _groupServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceAuthorizationSpecified { get; set; }

    }
}
