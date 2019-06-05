using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CallMeNowToDnCriteriaModify
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
        private BroadworksConnector.Ocip.Models.CriteriaReplacementDNList _phoneNumberList;

        [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList
        {
            get => _phoneNumberList;
            set
            {
                PhoneNumberListSpecified = true;
                _phoneNumberList = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberListSpecified { get; set; }
    }
}
