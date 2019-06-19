using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemCommunicationBarringCallTypeGetListRequest. Contains a table with one row per Communication Barring Call Type.  The table column headings are: "Call Type" and "Network Server Call Type".
    /// <see cref="SystemCommunicationBarringCallTypeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5323""}]")]
    public class SystemCommunicationBarringCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _callTypeTable;

        [XmlElement(ElementName = "callTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5323")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallTypeTable
        {
            get => _callTypeTable;
            set
            {
                CallTypeTableSpecified = true;
                _callTypeTable = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeTableSpecified { get; set; }

    }
}
