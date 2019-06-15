using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular BroadWorks Mobility Mobile Network.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactMobileNetwork : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private string _mobileNetworkName;

        [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
        public string MobileNetworkName {
            get => _mobileNetworkName;
            set {
                MobileNetworkNameSpecified = true;
                _mobileNetworkName = value;
            }
        }

        [XmlIgnore]
        public bool MobileNetworkNameSpecified { get; set; }
        
    }
}
