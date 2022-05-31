using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the
    /// SystemNetworkClassOfServiceGetAssignedSystemVoicePortalListRequest.
    /// The response contains a table of system voice portals that have
    /// the given Network Class of Service assigned. The column headings are
    /// "System Voice Portal Id" and "Name".
    /// <see cref="SystemNetworkClassOfServiceGetAssignedSystemVoicePortalListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12439""}]")]
    public class SystemNetworkClassOfServiceGetAssignedSystemVoicePortalListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _systemVoicePortalTable;

        [XmlElement(ElementName = "systemVoicePortalTable", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12439")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemVoicePortalTable
        {
            get => _systemVoicePortalTable;
            set
            {
                SystemVoicePortalTableSpecified = true;
                _systemVoicePortalTable = value;
            }
        }

        [XmlIgnore]
        protected bool SystemVoicePortalTableSpecified { get; set; }

    }
}
