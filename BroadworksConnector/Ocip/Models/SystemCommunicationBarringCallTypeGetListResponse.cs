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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5741""}]")]
    public class SystemCommunicationBarringCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callTypeTable;

        [XmlElement(ElementName = "callTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5741")]
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
        protected bool CallTypeTableSpecified { get; set; }

    }
}
