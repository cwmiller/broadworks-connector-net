using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get all the information of a VoiceXML instance.
    /// The response is either GroupVoiceXmlGetInstanceResponse19sp1 or ErrorResponse.
    /// 
    /// Replaced by: GroupVoiceXmlGetInstanceRequest22 in AS mode
    /// <see cref="GroupVoiceXmlGetInstanceResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupVoiceXmlGetInstanceRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:4731""}]")]
    public class GroupVoiceXmlGetInstanceRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.GroupVoiceXmlGetInstanceResponse19sp1>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4731")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

    }
}
