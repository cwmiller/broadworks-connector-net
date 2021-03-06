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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:1208""}]")]
    public class SystemAccessDeviceGetLinkedTreeDeviceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.TreeDeviceInfo _treeDeviceInfo;

        [XmlElement(ElementName = "treeDeviceInfo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:1208")]
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
