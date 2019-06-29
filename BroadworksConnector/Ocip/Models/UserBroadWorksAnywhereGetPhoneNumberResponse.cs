using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserBroadWorksAnywhereGetPhoneNumberRequest.
    /// The criteria table's column headings are: "Is Active", "Criteria Name", "Time Schedule",
    /// "Calls From", "Blacklisted", "Holiday Schedule", "Calls To Type", "Calls To Number" and "Calls To Extension".
    /// The following columns are only returned in AS data mode:
    /// "Calls To Type", "Calls To Number" and "Calls To Extension"
    /// 
    /// The possible values for the "Calls To Type" column are the following or a combination of them separated by comma:
    /// - Primary
    /// - Alternate X (where x is a number between 1 and 10)
    /// - Mobility
    /// The possible values for the "Calls To Number" column are the following or a combination of them separated by comma:
    /// - The value of the phone number for the corresponding Calls To Type, when the number is available. i.e. Alternate 1 may have extension, but no number.
    /// - When no number is available a blank space is provided instead.
    /// The possible values for the "Calls To Extension" column are the following or a caombination of them separated by comma:
    /// - The value of the extension for the corresponding Calls To Type, when the extension is available. i.e. Primary may have number, but no extension.
    /// - For Mobility Calls To Type, this is always blank.
    /// - When no exension is available a blank space is provided instead.
    /// <see cref="UserBroadWorksAnywhereGetPhoneNumberRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""72f634ecc58842ce9d362ca629a47ea9:452""}]")]
    public class UserBroadWorksAnywhereGetPhoneNumberResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        [MinLength(1)]
        [MaxLength(80)]
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
        protected bool DescriptionSpecified { get; set; }

        private string _outboundAlternateNumber;

        [XmlElement(ElementName = "outboundAlternateNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        [MinLength(1)]
        [MaxLength(161)]
        public string OutboundAlternateNumber
        {
            get => _outboundAlternateNumber;
            set
            {
                OutboundAlternateNumberSpecified = true;
                _outboundAlternateNumber = value;
            }
        }

        [XmlIgnore]
        protected bool OutboundAlternateNumberSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        private bool _broadworksCallControl;

        [XmlElement(ElementName = "broadworksCallControl", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        public bool BroadworksCallControl
        {
            get => _broadworksCallControl;
            set
            {
                BroadworksCallControlSpecified = true;
                _broadworksCallControl = value;
            }
        }

        [XmlIgnore]
        protected bool BroadworksCallControlSpecified { get; set; }

        private bool _useDiversionInhibitor;

        [XmlElement(ElementName = "useDiversionInhibitor", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        public bool UseDiversionInhibitor
        {
            get => _useDiversionInhibitor;
            set
            {
                UseDiversionInhibitorSpecified = true;
                _useDiversionInhibitor = value;
            }
        }

        [XmlIgnore]
        protected bool UseDiversionInhibitorSpecified { get; set; }

        private bool _answerConfirmationRequired;

        [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        public bool AnswerConfirmationRequired
        {
            get => _answerConfirmationRequired;
            set
            {
                AnswerConfirmationRequiredSpecified = true;
                _answerConfirmationRequired = value;
            }
        }

        [XmlIgnore]
        protected bool AnswerConfirmationRequiredSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"72f634ecc58842ce9d362ca629a47ea9:452")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable
        {
            get => _criteriaTable;
            set
            {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaTableSpecified { get; set; }

    }
}
