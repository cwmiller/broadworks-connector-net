using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User's Mobile Identity Read Entry
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:45378""}]")]
    public class BroadWorksMobilityUserMobileIdentityEntry
    {

        private string _mobileNumber;

        [XmlElement(ElementName = "mobileNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45378")]
        [MinLength(1)]
        [MaxLength(23)]
        public string MobileNumber
        {
            get => _mobileNumber;
            set
            {
                MobileNumberSpecified = true;
                _mobileNumber = value;
            }
        }

        [XmlIgnore]
        public bool MobileNumberSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45378")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

        private bool _isPrimary;

        [XmlElement(ElementName = "isPrimary", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45378")]
        public bool IsPrimary
        {
            get => _isPrimary;
            set
            {
                IsPrimarySpecified = true;
                _isPrimary = value;
            }
        }

        [XmlIgnore]
        public bool IsPrimarySpecified { get; set; }

        private bool _enableAlerting;

        [XmlElement(ElementName = "enableAlerting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:45378")]
        public bool EnableAlerting
        {
            get => _enableAlerting;
            set
            {
                EnableAlertingSpecified = true;
                _enableAlerting = value;
            }
        }

        [XmlIgnore]
        public bool EnableAlertingSpecified { get; set; }

    }
}
