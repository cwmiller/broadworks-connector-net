using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a static configuration tag.
    /// 
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// isTagValueEncrypted
    /// tagValueToEncrypt
    /// 
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8073"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8074""},{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8080""}]}]")]
    public class SystemDeviceManagementTagAddRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _systemDefaultTagSet;

        [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8074")]
        public bool SystemDefaultTagSet
        {
            get => _systemDefaultTagSet;
            set
            {
                SystemDefaultTagSetSpecified = true;
                _systemDefaultTagSet = value;
            }
        }

        [XmlIgnore]
        protected bool SystemDefaultTagSetSpecified { get; set; }

        protected string _tagSetName;

        [XmlElement(ElementName = "tagSetName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8074")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TagSetName
        {
            get => _tagSetName;
            set
            {
                TagSetNameSpecified = true;
                _tagSetName = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetNameSpecified { get; set; }

        protected string _tagName;

        [XmlElement(ElementName = "tagName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8073")]
        [MinLength(1)]
        [MaxLength(64)]
        public string TagName
        {
            get => _tagName;
            set
            {
                TagNameSpecified = true;
                _tagName = value;
            }
        }

        [XmlIgnore]
        protected bool TagNameSpecified { get; set; }

        protected bool _isTagValueEncrypted;

        [XmlElement(ElementName = "isTagValueEncrypted", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8073")]
        public bool IsTagValueEncrypted
        {
            get => _isTagValueEncrypted;
            set
            {
                IsTagValueEncryptedSpecified = true;
                _isTagValueEncrypted = value;
            }
        }

        [XmlIgnore]
        protected bool IsTagValueEncryptedSpecified { get; set; }

        protected string _tagValue;

        [XmlElement(ElementName = "tagValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8080")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValue
        {
            get => _tagValue;
            set
            {
                TagValueSpecified = true;
                _tagValue = value;
            }
        }

        [XmlIgnore]
        protected bool TagValueSpecified { get; set; }

        protected string _tagValueToEncrypt;

        [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:8080")]
        [MinLength(1)]
        [MaxLength(256)]
        public string TagValueToEncrypt
        {
            get => _tagValueToEncrypt;
            set
            {
                TagValueToEncryptSpecified = true;
                _tagValueToEncrypt = value;
            }
        }

        [XmlIgnore]
        protected bool TagValueToEncryptSpecified { get; set; }

        protected bool _isTagValueOverridable;

        [XmlElement(ElementName = "isTagValueOverridable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8073")]
        public bool IsTagValueOverridable
        {
            get => _isTagValueOverridable;
            set
            {
                IsTagValueOverridableSpecified = true;
                _isTagValueOverridable = value;
            }
        }

        [XmlIgnore]
        protected bool IsTagValueOverridableSpecified { get; set; }

    }
}
