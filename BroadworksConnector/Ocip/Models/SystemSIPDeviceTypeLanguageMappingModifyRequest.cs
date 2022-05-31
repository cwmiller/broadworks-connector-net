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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17308""}]")]
    public class SystemSIPDeviceTypeLanguageMappingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17308")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17308")]
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
