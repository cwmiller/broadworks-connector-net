using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of Communication Barring Authorization codes to a group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// Replaced by: GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1 in AS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCommunicationBarringAuthorizationCodeAddListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:2102""}]")]
    public class GroupCommunicationBarringAuthorizationCodeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2102")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2102")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry> _code = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringAuthorizationCodeEntry>();

        [XmlElement(ElementName = "code", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2102")]
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
