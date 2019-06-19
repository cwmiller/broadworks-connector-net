using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the group's digit collection attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4045""}]")]
    public class GroupDigitCollectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4045")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4045")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupDigitCollectionSettingLevel _useSetting;

        [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4045")]
        public BroadWorksConnector.Ocip.Models.GroupDigitCollectionSettingLevel UseSetting
        {
            get => _useSetting;
            set
            {
                UseSettingSpecified = true;
                _useSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingSpecified { get; set; }

        private string _accessCode;

        [XmlElement(ElementName = "accessCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4045")]
        [MinLength(1)]
        [MaxLength(1)]
        public string AccessCode
        {
            get => _accessCode;
            set
            {
                AccessCodeSpecified = true;
                _accessCode = value;
            }
        }

        [XmlIgnore]
        public bool AccessCodeSpecified { get; set; }

        private string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4045")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PublicDigitMap
        {
            get => _publicDigitMap;
            set
            {
                PublicDigitMapSpecified = true;
                _publicDigitMap = value;
            }
        }

        [XmlIgnore]
        public bool PublicDigitMapSpecified { get; set; }

        private string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4045")]
        [MinLength(1)]
        [MaxLength(2048)]
        public string PrivateDigitMap
        {
            get => _privateDigitMap;
            set
            {
                PrivateDigitMapSpecified = true;
                _privateDigitMap = value;
            }
        }

        [XmlIgnore]
        public bool PrivateDigitMapSpecified { get; set; }

    }
}
