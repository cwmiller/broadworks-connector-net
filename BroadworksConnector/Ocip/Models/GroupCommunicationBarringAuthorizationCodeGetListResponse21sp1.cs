using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1.
    /// Contains a list of Communication Barring Authorization Codes assigned to the group.
    /// <see cref="GroupCommunicationBarringAuthorizationCodeGetListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:2675""}]")]
    public class GroupCommunicationBarringAuthorizationCodeGetListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> _code = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration>();

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:2675")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeConfiguration> Code
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
