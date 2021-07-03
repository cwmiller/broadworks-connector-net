using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAccessDeviceGetLinkedTreeDeviceRequest.
    /// <see cref="ServiceProviderAccessDeviceGetLinkedTreeDeviceRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:796""}]")]
    public class ServiceProviderAccessDeviceGetLinkedTreeDeviceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.TreeDeviceInfo _treeDeviceInfo;

        [XmlElement(ElementName = "treeDeviceInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:796")]
        public BroadWorksConnector.Ocip.Models.TreeDeviceInfo TreeDeviceInfo
        {
            get => _treeDeviceInfo;
            set
            {
                TreeDeviceInfoSpecified = true;
                _treeDeviceInfo = value;
            }
        }

        [XmlIgnore]
        protected bool TreeDeviceInfoSpecified { get; set; }

    }
}
