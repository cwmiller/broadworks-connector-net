using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the associated device types and tagsets for a given device family.
    /// 
    /// The response is either SystemDeviceFamilyGetResponse or ErrorResponse.
    /// <see cref="SystemDeviceFamilyGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7601""}]")]
    public class SystemDeviceFamilyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDeviceFamilyGetResponse>
    {

        protected string _deviceFamilyName;

        [XmlElement(ElementName = "deviceFamilyName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7601")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DeviceFamilyName
        {
            get => _deviceFamilyName;
            set
            {
                DeviceFamilyNameSpecified = true;
                _deviceFamilyName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceFamilyNameSpecified { get; set; }

    }
}
