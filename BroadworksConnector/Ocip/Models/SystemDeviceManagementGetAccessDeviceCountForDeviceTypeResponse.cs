using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest.
    /// <see cref="SystemDeviceManagementGetAccessDeviceCountForDeviceTypeRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7930""}]")]
    public class SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _accessDeviceCount;

        [XmlElement(ElementName = "accessDeviceCount", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7930")]
        public int AccessDeviceCount
        {
            get => _accessDeviceCount;
            set
            {
                AccessDeviceCountSpecified = true;
                _accessDeviceCount = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceCountSpecified { get; set; }

    }
}
