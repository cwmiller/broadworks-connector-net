using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The To dn criteria used on the call me now external number.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf9583170c1dc9ec6c152ba1238437a:247""}]")]
    public class CallMeNowToDnCriteria
    {

        protected BroadWorksConnector.Ocip.Models.CriteriaDnSelection _toDnCriteriaSelection;

        [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false, Namespace = "")]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:247")]
        public BroadWorksConnector.Ocip.Models.CriteriaDnSelection ToDnCriteriaSelection
        {
            get => _toDnCriteriaSelection;
            set
            {
                ToDnCriteriaSelectionSpecified = true;
                _toDnCriteriaSelection = value;
            }
        }

        [XmlIgnore]
        protected bool ToDnCriteriaSelectionSpecified { get; set; }

        protected List<string> _phoneNumber = new List<string>();

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:247")]
        [MinLength(1)]
        [MaxLength(23)]
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
        protected bool PhoneNumberSpecified { get; set; }

    }
}
