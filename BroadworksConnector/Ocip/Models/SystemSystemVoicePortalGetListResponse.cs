using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSystemVoicePortalGetListRequest.
    /// The column headings are "Default", "System Voice Portal Id", "Name", "Network Voice Portal Number", "System Voice Portal Number" and "Language".
    /// The possible values for "Default" are true, false.
    /// <see cref="SystemSystemVoicePortalGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18393""}]")]
    public class SystemSystemVoicePortalGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _systemVoicePortalsTable;

        [XmlElement(ElementName = "systemVoicePortalsTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18393")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemVoicePortalsTable
        {
            get => _systemVoicePortalsTable;
            set
            {
                SystemVoicePortalsTableSpecified = true;
                _systemVoicePortalsTable = value;
            }
        }

        [XmlIgnore]
        protected bool SystemVoicePortalsTableSpecified { get; set; }

    }
}
