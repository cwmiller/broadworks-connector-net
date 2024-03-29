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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:4303""}]")]
    public class ProfileAndServiceCallForwardingSelectiveInfo
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4303")]
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

        protected string _defaultForwardToPhoneNumber;

        [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4303")]
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

        protected bool _playRingReminder;

        [XmlElement(ElementName = "playRingReminder", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4303")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:4303")]
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
