using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Webex Meetings call processing entry.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19611""}]")]
    public class SystemWebexMeetingsCallTypeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19611")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected string _networkServerCallType;

        [XmlElement(ElementName = "networkServerCallType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19611")]
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

        protected bool _enforceNSChargeField;

        [XmlElement(ElementName = "enforceNSChargeField", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19611")]
        public bool EnforceNSChargeField
        {
            get => _enforceNSChargeField;
            set
            {
                EnforceNSChargeFieldSpecified = true;
                _enforceNSChargeField = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceNSChargeFieldSpecified { get; set; }

        protected bool _processAsInternalForSACSubscriber;

        [XmlElement(ElementName = "processAsInternalForSACSubscriber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19611")]
        public bool ProcessAsInternalForSACSubscriber
        {
            get => _processAsInternalForSACSubscriber;
            set
            {
                ProcessAsInternalForSACSubscriberSpecified = true;
                _processAsInternalForSACSubscriber = value;
            }
        }

        [XmlIgnore]
        protected bool ProcessAsInternalForSACSubscriberSpecified { get; set; }

    }
}
