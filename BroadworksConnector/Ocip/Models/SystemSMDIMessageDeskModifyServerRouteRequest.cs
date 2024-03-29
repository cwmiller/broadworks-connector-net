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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""aa3a240fa755015613cfb9259eccafef:200""}]")]
    public class SystemSMDIMessageDeskModifyServerRouteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _routeDestination;

        [XmlElement(ElementName = "routeDestination", IsNullable = false, Namespace = "")]
        [Group(@"aa3a240fa755015613cfb9259eccafef:200")]
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

        protected BroadWorksConnector.Ocip.Models.SystemSMDIMessageDeskModifyServerRouteRequestDeviceNameList _deviceNameList;

        [XmlElement(ElementName = "deviceNameList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"aa3a240fa755015613cfb9259eccafef:200")]
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
