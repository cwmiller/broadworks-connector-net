using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringUserControlGetRequest.
    /// Contains the settings to whole system for Communication Barring User-Control
    /// <see cref="SystemCommunicationBarringUserControlGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4277c572e54919d6e29f4c0fa69aaad1:59""}]")]
    public class SystemCommunicationBarringUserControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableLockout;

        [XmlElement(ElementName = "enableLockout", IsNullable = false, Namespace = "")]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:59")]
        public bool EnableLockout
        {
            get => _enableLockout;
            set
            {
                EnableLockoutSpecified = true;
                _enableLockout = value;
            }
        }

        [XmlIgnore]
        public bool EnableLockoutSpecified { get; set; }

        private int _maxNumberOfFailedAttempts;

        [XmlElement(ElementName = "maxNumberOfFailedAttempts", IsNullable = false, Namespace = "")]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:59")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaxNumberOfFailedAttempts
        {
            get => _maxNumberOfFailedAttempts;
            set
            {
                MaxNumberOfFailedAttemptsSpecified = true;
                _maxNumberOfFailedAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaxNumberOfFailedAttemptsSpecified { get; set; }

        private int _lockoutMinutes;

        [XmlElement(ElementName = "lockoutMinutes", IsNullable = false, Namespace = "")]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:59")]
        [MinInclusive(1)]
        [MaxInclusive(600)]
        public int LockoutMinutes
        {
            get => _lockoutMinutes;
            set
            {
                LockoutMinutesSpecified = true;
                _lockoutMinutes = value;
            }
        }

        [XmlIgnore]
        public bool LockoutMinutesSpecified { get; set; }

    }
}
