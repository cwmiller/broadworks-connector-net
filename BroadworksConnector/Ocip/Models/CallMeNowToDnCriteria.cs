using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallMeNowToDnCriteria
    {
        private BroadworksConnector.Ocip.Models.CriteriaDnSelection _toDnCriteriaSelection;

        [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CriteriaDnSelection ToDnCriteriaSelection
        {
            get => _toDnCriteriaSelection;
            set
            {
                ToDnCriteriaSelectionSpecified = true;
                _toDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        public bool ToDnCriteriaSelectionSpecified { get; set; }
        private List<string> _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        public List<string> PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberSpecified { get; set; }
    }
}
