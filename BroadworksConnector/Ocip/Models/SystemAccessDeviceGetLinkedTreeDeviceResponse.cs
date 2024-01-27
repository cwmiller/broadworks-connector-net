using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccessDeviceGetLinkedTreeDeviceRequest.
    /// <see cref="SystemAccessDeviceGetLinkedTreeDeviceRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1224""}]")]
    public class SystemAccessDeviceGetLinkedTreeDeviceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TreeDeviceInfo _treeDeviceInfo;

        [XmlElement(ElementName = "treeDeviceInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:1224")]
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
