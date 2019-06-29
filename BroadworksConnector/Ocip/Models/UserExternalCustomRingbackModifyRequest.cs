using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with External Custom Ringback.
    /// The user SIP URI, when selected, it replaces the SP address, port and prefix.
    /// The user SIP URI, if selected, is the Request URI of the SIP INVITE sent
    /// to the external server.  When the service provider data is used instead,
    /// the Request URI is constructed using the prefix, address, port and the user DN.
    /// The timeout value is the only SP configuration used when the user SIP URI is selected.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8df43dca23d99d8ab44c0082aadfbe0:139""}]")]
    public class UserExternalCustomRingbackModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:139")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:139")]
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

        private BroadWorksConnector.Ocip.Models.ExternalCustomRingbackSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:139")]
        public BroadWorksConnector.Ocip.Models.ExternalCustomRingbackSettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UseSettingLevelSpecified { get; set; }

        private string _sipRequestURI;

        [XmlElement(ElementName = "sipRequestURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:139")]
        [MinLength(1)]
        [MaxLength(1020)]
        public string SipRequestURI
        {
            get => _sipRequestURI;
            set
            {
                SipRequestURISpecified = true;
                _sipRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool SipRequestURISpecified { get; set; }

    }
}
