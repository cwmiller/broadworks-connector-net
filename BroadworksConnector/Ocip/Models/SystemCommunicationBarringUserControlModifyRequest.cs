using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's Communication Barring User-Control settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4277c572e54919d6e29f4c0fa69aaad1:77""}]")]
    public class SystemCommunicationBarringUserControlModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _enableLockout;

        [XmlElement(ElementName = "enableLockout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:77")]
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
        protected bool EnableLockoutSpecified { get; set; }

        protected int _maxNumberOfFailedAttempts;

        [XmlElement(ElementName = "maxNumberOfFailedAttempts", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:77")]
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
        protected bool MaxNumberOfFailedAttemptsSpecified { get; set; }

        protected int _lockoutMinutes;

        [XmlElement(ElementName = "lockoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4277c572e54919d6e29f4c0fa69aaad1:77")]
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
        protected bool LockoutMinutesSpecified { get; set; }

    }
}
