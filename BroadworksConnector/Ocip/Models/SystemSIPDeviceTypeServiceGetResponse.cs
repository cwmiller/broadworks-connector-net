using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSIPDeviceTypeServiceGetRequest.
    /// Contains the list of device type services integrated to BroadWorks.
    /// <see cref="SystemSIPDeviceTypeServiceGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17672""}]")]
    public class SystemSIPDeviceTypeServiceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _supportsPolycomPhoneServices;

        [XmlElement(ElementName = "supportsPolycomPhoneServices", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17672")]
        public bool SupportsPolycomPhoneServices
        {
            get => _supportsPolycomPhoneServices;
            set
            {
                SupportsPolycomPhoneServicesSpecified = true;
                _supportsPolycomPhoneServices = value;
            }
        }

        [XmlIgnore]
        protected bool SupportsPolycomPhoneServicesSpecified { get; set; }

    }
}
