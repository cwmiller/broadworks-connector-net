using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Communication Barring Call Type.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5695""}]")]
    public class SystemCommunicationBarringCallTypeAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _callType;

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5695")]
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
        protected bool CallTypeSpecified { get; set; }

        protected string _networkServerCallType;

        [XmlElement(ElementName = "networkServerCallType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:5695")]
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
        protected bool NetworkServerCallTypeSpecified { get; set; }

    }
}
