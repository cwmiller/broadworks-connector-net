using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest.
    /// <see cref="ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:3065""}]")]
    public class ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _accessDeviceCount;

        [XmlElement(ElementName = "accessDeviceCount", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:3065")]
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
