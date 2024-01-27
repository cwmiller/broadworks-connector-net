using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The To dn criteria used on the call me now external number to be modified.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf9583170c1dc9ec6c152ba1238437a:259""}]")]
    public class CallMeNowToDnCriteriaModify
    {

        protected BroadWorksConnector.Ocip.Models.CriteriaDnSelection _toDnCriteriaSelection;

        [XmlElement(ElementName = "toDnCriteriaSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:259")]
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

        protected BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList _phoneNumberList;

        [XmlElement(ElementName = "phoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:259")]
        public BroadWorksConnector.Ocip.Models.CriteriaReplacementDNList PhoneNumberList
        {
            get => _phoneNumberList;
            set
            {
                PhoneNumberListSpecified = true;
                _phoneNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberListSpecified { get; set; }

    }
}
