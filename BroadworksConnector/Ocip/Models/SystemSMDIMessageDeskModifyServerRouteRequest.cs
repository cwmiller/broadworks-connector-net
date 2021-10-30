using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Replace the list of devices associated with a SMDI server route destination.
    /// There must be at least one device in the list.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:200""}]")]
    public class SystemSMDIMessageDeskModifyServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _routeDestination;

        [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:200")]
        [MinLength(1)]
        [MaxLength(10)]
        public string RouteDestination
        {
            get => _routeDestination;
            set
            {
                RouteDestinationSpecified = true;
                _routeDestination = value;
            }
        }

        [XmlIgnore]
        protected bool RouteDestinationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList _deviceNameList;

        [XmlElement(ElementName = "deviceNameList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:200")]
        public BroadWorksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList DeviceNameList
        {
            get => _deviceNameList;
            set
            {
                DeviceNameListSpecified = true;
                _deviceNameList = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceNameListSpecified { get; set; }

    }
}
