using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a SystemWebexMeetingsCallTypeGetListRequest. Contains a table with one row per Webex Meetings call type entry.  The table column headings are: "Name", "NS Call Type", "Enforce NS Charge Field" and "Process As Internal For SAC-Subscriber".
    /// <see cref="SystemWebexMeetingsCallTypeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19595""}]")]
    public class SystemWebexMeetingsCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callTypeTable;

        [XmlElement(ElementName = "callTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19595")]
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
