using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallForwardingSelectiveGetRequest16. The criteria table's column headings are:
    /// "Is Active", "Criteria Name", "Time Schedule", "Calls From", "Forward To", "Blacklisted", "Holiday Schedule", "Calls To Type", "Calls To Number" and "Calls To Extension".
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
    /// The possible values for the "Calls To Extension" column are the following or a combination of them separated by comma:
    /// - The value of the extension for the corresponding Calls To Type, when the extension is available. i.e. Primary may have number, but no extension.
    /// - For Mobility Calls To Type, this is always blank.
    /// - When no extension is available a blank space is provided instead.
    /// <see cref="UserCallForwardingSelectiveGetRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""543304bb75006bfa60814c897fa03ec0:158""}]")]
    public class UserCallForwardingSelectiveGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"543304bb75006bfa60814c897fa03ec0:158")]
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

        private string _defaultForwardToPhoneNumber;

        [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"543304bb75006bfa60814c897fa03ec0:158")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DefaultForwardToPhoneNumber
        {
            get => _defaultForwardToPhoneNumber;
            set
            {
                DefaultForwardToPhoneNumberSpecified = true;
                _defaultForwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultForwardToPhoneNumberSpecified { get; set; }

        private bool _playRingReminder;

        [XmlElement(ElementName = "playRingReminder", IsNullable = false, Namespace = "")]
        [Group(@"543304bb75006bfa60814c897fa03ec0:158")]
        public bool PlayRingReminder
        {
            get => _playRingReminder;
            set
            {
                PlayRingReminderSpecified = true;
                _playRingReminder = value;
            }
        }

        [XmlIgnore]
        protected bool PlayRingReminderSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"543304bb75006bfa60814c897fa03ec0:158")]
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
