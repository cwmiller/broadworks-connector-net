using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Call Forwarding Selective service
    /// 
    /// The criteria table's column headings are:
    /// "Is Active", "Criteria Name", "Time Schedule", "Calls From", "Forward To", "Blacklisted", "Holiday Schedule"
    /// 
    /// The "Calls From" column is a string containing call numbers
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4294""}]")]
    public class ProfileAndServiceCallForwardingSelectiveInfo
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4294")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4294")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4294")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4294")]
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
