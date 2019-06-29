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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:2340""}]")]
    public class ServiceProviderDeviceManagementGetAccessDeviceCountForDeviceTypeServiceProviderResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _accessDeviceCount;

        [XmlElement(ElementName = "accessDeviceCount", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:2340")]
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
