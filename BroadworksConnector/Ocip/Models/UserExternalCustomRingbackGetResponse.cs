using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserExternalCustomRingbackGetRequest.
    /// <see cref="UserExternalCustomRingbackGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a8df43dca23d99d8ab44c0082aadfbe0:116""}]")]
    public class UserExternalCustomRingbackGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:116")]
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
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:116")]
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

        [XmlElement(ElementName = "sipRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a8df43dca23d99d8ab44c0082aadfbe0:116")]
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
