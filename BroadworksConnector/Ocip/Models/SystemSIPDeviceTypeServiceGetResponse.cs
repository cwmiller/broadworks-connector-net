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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16554""}]")]
    public class SystemSIPDeviceTypeServiceGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _supportsPolycomPhoneServices;

        [XmlElement(ElementName = "supportsPolycomPhoneServices", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16554")]
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
        public bool SupportsPolycomPhoneServicesSpecified { get; set; }

    }
}
