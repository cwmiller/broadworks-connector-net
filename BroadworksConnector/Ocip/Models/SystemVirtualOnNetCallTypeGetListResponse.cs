using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVirtualOnNetCallTypeGetListRequest.
    /// Contains a table with column headings:
    /// "Virtual On-Net Call Type Name", "Virtual On-Net Call Type CDR Value"
    /// in a row for each Virtual On-Net Call Type.
    /// <see cref="SystemVirtualOnNetCallTypeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef8bc875d664cdc920228d455073e594:293""}]")]
    public class SystemVirtualOnNetCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _virtualOnNetCallTypeTable;

        [XmlElement(ElementName = "virtualOnNetCallTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"ef8bc875d664cdc920228d455073e594:293")]
        public BroadWorksConnector.Ocip.Models.C.OCITable VirtualOnNetCallTypeTable
        {
            get => _virtualOnNetCallTypeTable;
            set
            {
                VirtualOnNetCallTypeTableSpecified = true;
                _virtualOnNetCallTypeTable = value;
            }
        }

        [XmlIgnore]
        protected bool VirtualOnNetCallTypeTableSpecified { get; set; }

    }
}
