using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the device language name that is mapped to a BroadWorks language name. The request can be used to map many languages.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17535""}]")]
    public class SystemSIPDeviceTypeLanguageMappingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17535")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.DeviceManagementLanguageMapping> _languageMapping = new List<BroadWorksConnector.Ocip.Models.DeviceManagementLanguageMapping>();

        [XmlElement(ElementName = "languageMapping", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17535")]
        public List<BroadWorksConnector.Ocip.Models.DeviceManagementLanguageMapping> LanguageMapping
        {
            get => _languageMapping;
            set
            {
                LanguageMappingSpecified = true;
                _languageMapping = value;
            }
        }

        [XmlIgnore]
        protected bool LanguageMappingSpecified { get; set; }

    }
}
