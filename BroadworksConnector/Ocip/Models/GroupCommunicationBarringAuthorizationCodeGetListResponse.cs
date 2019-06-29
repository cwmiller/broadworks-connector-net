using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCommunicationBarringAuthorizationCodeGetListRequest.
    /// Contains a list of Communication Barring Authorization Codes
    /// assigned to the group.
    /// 
    /// Replaced by: GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 in AS data mode
    /// <see cref="GroupCommunicationBarringAuthorizationCodeGetListRequest"/>
    /// <see cref="GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:4555""}]")]
    public class GroupCommunicationBarringAuthorizationCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> _code = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry>();

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:4555")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> Code
        {
            get => _code;
            set
            {
                CodeSpecified = true;
                _code = value;
            }
        }

        [XmlIgnore]
        protected bool CodeSpecified { get; set; }

    }
}
