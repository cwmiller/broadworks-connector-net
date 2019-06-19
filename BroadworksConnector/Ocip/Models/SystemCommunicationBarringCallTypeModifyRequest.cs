using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Communication Barring Call Type.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5339""}]")]
    public class SystemCommunicationBarringCallTypeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5339")]
        [MinLength(1)]
        [MaxLength(40)]
        public string CallType
        {
            get => _callType;
            set
            {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        public bool CallTypeSpecified { get; set; }

        private string _networkServerCallType;

        [XmlElement(ElementName = "networkServerCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5339")]
        [MinLength(1)]
        [MaxLength(4)]
        public string NetworkServerCallType
        {
            get => _networkServerCallType;
            set
            {
                NetworkServerCallTypeSpecified = true;
                _networkServerCallType = value;
            }
        }

        [XmlIgnore]
        public bool NetworkServerCallTypeSpecified { get; set; }

    }
}
