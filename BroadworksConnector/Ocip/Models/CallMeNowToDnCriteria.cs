using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The To dn criteria used on the call me now external number.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CallMeNowToDnCriteria 
    {

        
        private BroadWorksConnector.Ocip.Models.CriteriaDnSelection _toDnCriteriaSelection;

        [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CriteriaDnSelection ToDnCriteriaSelection {
            get => _toDnCriteriaSelection;
            set {
                ToDnCriteriaSelectionSpecified = true;
                _toDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        public bool ToDnCriteriaSelectionSpecified { get; set; }
        
        private List<string> _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public List<string> PhoneNumber {
            get => _phoneNumber;
            set {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
        
    }
}
