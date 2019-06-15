using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of group services that replaces a previously authorized group services.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementCombinedGroupServiceAuthorizationList 
    {

        
        private List<BroadWorksConnector.Ocip.Models.CombinedGroupServiceAuthorization> _groupServiceAuthorization;

        [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.CombinedGroupServiceAuthorization> GroupServiceAuthorization {
            get => _groupServiceAuthorization;
            set {
                GroupServiceAuthorizationSpecified = true;
                _groupServiceAuthorization = value;
            }
        }

        [XmlIgnore]
        public bool GroupServiceAuthorizationSpecified { get; set; }
        
    }
}
